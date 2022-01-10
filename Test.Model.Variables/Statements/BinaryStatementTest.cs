using Model.Variables.Operators;
using Model.Variables.Variables;
using Model.Variables.Statement;
using NUnit.Framework;

namespace Test.Model.Variables.Statements
{
	public class BinaryStatementTest
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
		public void BinaryPlusTest()
		{
			Plus op = new Plus();

			Assert.AreEqual(twoInt, new BinaryStatement(op, oneInt, oneInt).Evaluate() );
			Assert.AreEqual(zeroInt, new BinaryStatement(op, minusOneInt, oneInt).Evaluate() );

			Assert.AreEqual(oneHalfFloat, new BinaryStatement(op, oneFloat, halfFloat).Evaluate());
			Assert.AreEqual(halfFloat, new BinaryStatement(op, minusOneFloat, oneHalfFloat).Evaluate());

			Assert.AreEqual(b, new BinaryStatement(op, empty, b).Evaluate());
			Assert.AreEqual(ab, new BinaryStatement(op, a, b).Evaluate());
		}

		[Test]
		public void BinaryPlusErrorTest()
		{
			Plus op = new Plus();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, t).Evaluate() );
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, ab).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroInt, halfFloat).Evaluate());
		}

		[Test]
		public void BinaryMinusTest()
		{
			Minus op = new Minus();

			Assert.AreEqual(minusOneInt, new BinaryStatement(op, oneInt, twoInt).Evaluate() );
			Assert.AreEqual(twoInt, new BinaryStatement(op, oneInt, minusOneInt).Evaluate());
			Assert.AreEqual(halfFloat, new BinaryStatement(op, oneFloat, halfFloat).Evaluate());
		}

		[Test]
		public void BinaryMinusErrorTest()
		{
			Minus op = new Minus();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, t).Evaluate() );
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, ab).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroInt, halfFloat).Evaluate());
		}

		[Test]
		public void BinaryMultiplyTest()
		{
			Multiply op = new Multiply();

			Assert.AreEqual(new Integer(12), new BinaryStatement(op, new Integer(3), new Integer(4)).Evaluate());
			Assert.AreEqual(oneHalfFloat, new BinaryStatement(op, halfFloat, new Float(3)).Evaluate());
		}

		[Test]
		public void BinaryMultiplyErrorTest()
		{
			Multiply op = new Multiply();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, t).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, ab).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroInt, halfFloat).Evaluate());
		}

		[Test]
		public void BinaryDivideTest()
		{
			Divide op = new Divide();

			Assert.AreEqual(twoInt, new BinaryStatement(op, twoInt, oneInt).Evaluate());
			Assert.AreEqual(new Float(3.0f), new BinaryStatement(op, oneHalfFloat, halfFloat).Evaluate());

		}

		[Test]
		public void BinaryDivideErrorTest()
		{
			Divide op = new Divide();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, halfFloat).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, a).Evaluate());
		}

		[Test]
		public void BinaryModuloTest()
		{
			Modulo op = new Modulo();

			Assert.AreEqual(zeroInt, new BinaryStatement(op, oneInt, oneInt).Evaluate());
			Assert.AreEqual(oneInt, new BinaryStatement(op, new Integer(3), twoInt).Evaluate());
			Assert.AreEqual(halfFloat, new BinaryStatement(op, oneHalfFloat, oneFloat).Evaluate());
		}

		[Test]
		public void BinaryModuloErrorTest()
		{
			Modulo op = new Modulo();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, halfFloat).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, a).Evaluate());
		}

		[Test]
		public void BinaryAndTest()
		{
			And op = new And();

			Assert.AreEqual(t, new BinaryStatement(op, t, t).Evaluate() );
			Assert.AreEqual(f, new BinaryStatement(op, t, f).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, f, t).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, f, f).Evaluate());
		}

		[Test]
		public void BinaryAndErrorTest()
		{
			And op = new And();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, zeroInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, a, oneFloat).Evaluate());
		}

		[Test]
		public void BinaryOrTest()
		{
			Or op = new Or();

			Assert.AreEqual(t, new BinaryStatement(op, t, f).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, t, t).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, f, f).Evaluate());
		}

		[Test]
		public void BinaryOrErrorTest()
		{
			Or op = new Or();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroInt, oneInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, halfFloat).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, a).Evaluate());
		}

		[Test]
		public void BinaryEqualTest()
		{
			Equality op = new Equality();

			Assert.AreEqual(f, new BinaryStatement(op, t, f).Evaluate() );
			Assert.AreEqual(t, new BinaryStatement(op, t, t).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, a, a).Evaluate());
		}

		[Test]
		public void BinaryEqualErrorTest()
		{
			Equality op = new Equality();

			Assert.Throws<System.InvalidOperationException> (() => new BinaryStatement(op, t, ba).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, oneInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, new String("1")).Evaluate());
		}

		[Test]
		public void BinaryInEqualTest()
		{
			InEquality op = new InEquality();

			Assert.AreEqual(t, new BinaryStatement(op, t, f).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, t, t).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, a, a).Evaluate());
		}

		[Test]
		public void BinaryInEqualErrorTest()
		{
			InEquality op = new InEquality();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, ba).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, oneInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneInt, new String("1")).Evaluate());
		}

		[Test]
		public void BinaryLessTest()
		{
			Less op = new Less();

			Assert.AreEqual(f, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, minusOneInt, zeroInt).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, halfFloat, zeroFloat).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, zeroFloat, zeroFloat).Evaluate());
		}

		[Test]
		public void BinaryLessErrorTest()
		{
			Less op = new Less();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, zeroInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, f).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, t).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, f, zeroInt).Evaluate());
		}

		[Test]
		public void BinaryLessEqualTest()
		{
			LessEq op = new LessEq();

			Assert.AreEqual(f, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, minusOneInt, zeroInt).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, halfFloat, zeroFloat).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, zeroFloat, zeroFloat).Evaluate());
		}

		[Test]
		public void BinaryLessEqualErrorTest()
		{
			LessEq op = new LessEq();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, zeroInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, f).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, t).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, f, zeroInt).Evaluate());
		}

		[Test]
		public void BinaryGreaterTest()
		{
			Greater op = new Greater();

			Assert.AreEqual(t, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, minusOneInt, zeroInt).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, halfFloat, zeroFloat).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, zeroFloat, zeroFloat).Evaluate());
		}

		[Test]
		public void BinaryGreaterErrorTest()
		{
			Greater op = new Greater();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, zeroInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, f).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, t).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, f, zeroInt).Evaluate());
		}

		[Test]
		public void BinaryGreaterEqualTest()
		{
			GreaterEq op = new GreaterEq();

			Assert.AreEqual( t, new BinaryStatement(op, oneInt, zeroInt).Evaluate());
			Assert.AreEqual(f, new BinaryStatement(op, minusOneInt, zeroInt).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, halfFloat, zeroFloat).Evaluate());
			Assert.AreEqual(t, new BinaryStatement(op, zeroFloat, zeroFloat).Evaluate());
		}

		[Test]
		public void BinaryGreaterEqualErrorTest()
		{
			GreaterEq op = new GreaterEq();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, zeroInt).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, ab, a).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, t, f).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloat, t).Evaluate());
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, f, zeroInt).Evaluate());
		}

	}
}
