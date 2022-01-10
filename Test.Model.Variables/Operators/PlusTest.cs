using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class PlusTest
	{
		Plus plus = new Plus();

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

			Assert.AreEqual(zero, plus.Execute(zero, zero));
			Assert.AreEqual(one, plus.Execute(zero, one));
			Assert.AreEqual(one, plus.Execute(one, zero));
			Assert.AreEqual(two, plus.Execute(one, one));

			Assert.AreEqual(zero, plus.Execute(minusOne, one));
			Assert.AreEqual(minusOne, plus.Execute(minusOne, zero));
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

			Assert.AreEqual(zero, plus.Execute(zero, zero));
			Assert.AreEqual(one, plus.Execute(zero, one));
			Assert.AreEqual(one, plus.Execute(one, zero));
			Assert.AreEqual(two, plus.Execute(one, one));
			Assert.AreEqual(oneHalf, plus.Execute(one, half));
			Assert.AreEqual(oneHalf, plus.Execute(half, one));

			Assert.AreEqual(zero, plus.Execute(minusOne, one));
			Assert.AreEqual(minusOne, plus.Execute(minusOne, zero));
		}

		[Test]
		public void StringTest()
		{
			String empty = new String("");
			String a = new String("a");
			String b = new String("b");
			String ab = new String("ab");
			String ba = new String("ba");

			Assert.AreEqual(empty, plus.Execute(empty, empty));
			Assert.AreEqual(a, plus.Execute(empty, a));
			Assert.AreEqual(a, plus.Execute(a, empty));
			Assert.AreEqual(ab, plus.Execute(a, b));
			Assert.AreEqual(ba, plus.Execute(b, a));
		}

		[Test]
		public void ErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => plus.Execute(new Integer(1), new String("a")));
			Assert.Throws<System.InvalidOperationException>(() => plus.Execute(new Integer(1), new Boolean(true)));
			Assert.Throws<System.InvalidOperationException>(() => plus.Execute(new Integer(1), new Float(0.0f)));
		}
	}
}
