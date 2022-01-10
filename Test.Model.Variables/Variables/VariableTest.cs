using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Variables
{
	public class VariableTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void IntegerTest()
		{
			Integer zero = new Integer(0);
			Integer one = new Integer(1);
			Integer minusOne = new Integer(-1);

			Assert.AreEqual(zero, zero);
			Assert.AreNotEqual(zero, one);
			Assert.AreNotEqual(zero, minusOne);

			Assert.AreEqual(one, one);
			Assert.AreNotEqual(one, minusOne);

			Assert.AreEqual(minusOne, minusOne);

			Assert.IsTrue(zero < one);
			Assert.IsTrue(minusOne < one);
			Assert.IsTrue(minusOne < zero);
		}

		[Test]
		public void FloatTest()
		{
			Float zero = new Float(0.0f);
			Float one = new Float(1.0f);
			Float minusOne = new Float(-1.0f);
			Float half = new Float(0.5f);

			Assert.AreEqual(zero, zero);
			Assert.AreNotEqual(zero, one);
			Assert.AreNotEqual(zero, minusOne);

			Assert.AreEqual(one, one);
			Assert.AreNotEqual(one, minusOne);

			Assert.AreEqual(minusOne, minusOne);

			Assert.IsTrue(zero < half);
			Assert.IsTrue(half < one);
			Assert.IsTrue(zero < one);
			Assert.IsTrue(minusOne < one);
		}

		[Test]
		public void BooleanTest()
		{
			Boolean t = true;
			Boolean f = false;

			Assert.AreEqual(t, t);
			Assert.AreNotEqual(t, f);
			Assert.AreEqual(t, new Boolean(true));

			Assert.IsTrue(t);
			Assert.IsFalse(f);
		}

		[Test]
		public void StringTest()
		{
			String empty = new String("");
			String a = new String("a");
			String imp = "implicit";

			Assert.AreEqual(empty, empty);
			Assert.AreEqual(a, a);
			Assert.AreNotEqual(empty, a);
			Assert.AreNotEqual(imp, a);
			Assert.AreNotEqual(empty, imp);
			Assert.AreEqual(imp, new String("implicit"));
		}
	}

}