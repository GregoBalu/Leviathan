using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class MultiplyTest
	{
		Multiply mul = new Multiply();

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void IntTest()
		{
			Integer minusOne = new Integer(-1);
			Integer zero = new Integer(0);
			Integer one = new Integer(1);
			Integer two = new Integer(2);

			Assert.AreEqual(zero, mul.Execute(zero, one));
			Assert.AreEqual(zero, mul.Execute(zero, two));
			Assert.AreEqual(zero, mul.Execute(two, zero));
			Assert.AreEqual(one, mul.Execute(one, one));
			Assert.AreEqual(two, mul.Execute(two, one));
			Assert.AreEqual(new Integer(4), mul.Execute(two, two));

			Assert.AreEqual(minusOne, mul.Execute(minusOne, one));
		}

		[Test]
		public void FloatTest()
		{
			Float minusOne = new Float(-1f);
			Float zero = new Float(0f);
			Float half = new Float(0.5f);
			Float one = new Float(1f);
			Float oneHalf = new Float(1.5f);
			Float two = new Float(2f);

			Assert.AreEqual(zero, mul.Execute(zero, one));
			Assert.AreEqual(zero, mul.Execute(zero, two));
			Assert.AreEqual(zero, mul.Execute(two, zero));
			Assert.AreEqual(one, mul.Execute(one, one));
			Assert.AreEqual(two, mul.Execute(two, one));
			Assert.AreEqual(new Float(4), mul.Execute(two, two));
			Assert.AreEqual(one, mul.Execute(two, half));

			Assert.AreEqual(minusOne, mul.Execute(minusOne, one));
		}


		[Test]
		public void ErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => mul.Execute(new Integer(1), new String("a")));
			Assert.Throws<System.InvalidOperationException>(() => mul.Execute(new Integer(1), new Boolean(true)));
			Assert.Throws<System.InvalidOperationException>(() => mul.Execute(new Integer(1), new Float(0.0f)));

			Assert.Throws<System.InvalidOperationException>(() => mul.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => mul.Execute(new Boolean(true), new Boolean(false)));
		}
	}
}
