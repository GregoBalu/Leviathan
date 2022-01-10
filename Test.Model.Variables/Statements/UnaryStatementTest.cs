using Model.Variables.Operators;
using Model.Variables.Variables;
using Model.Variables.Statement;
using NUnit.Framework;

namespace Test.Model.Variables.Statements
{
	public class UnaryStatementTest
	{
		private readonly Boolean t = true;
		private readonly Boolean f = false;

		private readonly Integer minusOneInt = new Integer(-1);
		private readonly Integer zeroInt = new Integer(0);
		private readonly Integer oneInt = new Integer(1);
		private readonly Integer twoInt = new Integer(2);

		private readonly Float minusOneFloat = new Float(-1.0f);
		private readonly Float zeroFloat = new Float(0.0f);
		private readonly Float halfFloat = new Float(0.5f);
		private readonly Float oneFloat = new Float(1.0f);
		private readonly Float oneHalfFloat = new Float(1.5f);

		private readonly String empty = "";
		private readonly String a = "a";
		private readonly String b = "b";
		private readonly String ab = "ab";
		private readonly String ba = "ba";

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void UnaryNegateTest()
		{
			Negate neg = new Negate();
			
			UnaryStatement negT = new UnaryStatement(neg, t);
			UnaryStatement negF = new UnaryStatement(neg, f);

			Assert.AreEqual(f, negT.Evaluate());
			Assert.AreNotEqual(negF.Evaluate(), negT.Evaluate());

			Assert.AreEqual(t, new UnaryStatement(neg, negT.Evaluate()).Evaluate());
		}

		[Test]
		public void UnaryNegativeTest()
		{
			Negative op = new Negative();

			Assert.AreEqual(zeroInt, new UnaryStatement(op, zeroInt).Evaluate());
			Assert.AreEqual(minusOneInt, new UnaryStatement(op, oneInt).Evaluate());

			Assert.AreEqual(zeroFloat, new UnaryStatement(op, zeroFloat).Evaluate());
			Assert.AreEqual(minusOneFloat, new UnaryStatement(op, oneFloat).Evaluate());
		}

		[Test]
		public void UnaryIncrementTest()
		{
			Increment op = new Increment();

			Assert.AreEqual(twoInt, new UnaryStatement(op, oneInt).Evaluate());

			Assert.AreEqual(zeroInt, new UnaryStatement(op, minusOneInt).Evaluate());

			Assert.AreEqual(twoInt, new UnaryStatement(op, new UnaryStatement(op, zeroInt).Evaluate()).Evaluate() );
		}

		[Test]
		public void UnaryDecrementTest()
		{
			Decrement op = new Decrement();

			Assert.AreEqual(zeroInt, new UnaryStatement(op, oneInt).Evaluate());
			Assert.AreEqual(minusOneInt, new UnaryStatement(op, zeroInt).Evaluate());

			Assert.AreEqual(zeroInt, new UnaryStatement(op, new UnaryStatement(op, twoInt).Evaluate()).Evaluate() );
		}

	}
}
