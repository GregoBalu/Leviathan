using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class DivideTest
	{
		Divide div = new Divide();

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

			Assert.AreEqual(zero, div.Execute(zero, one));
			Assert.AreEqual(two, div.Execute(two, one));
			Assert.AreEqual(one, div.Execute(two, two));
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

			Assert.AreEqual(zero, div.Execute(zero, one));
			Assert.AreEqual(two, div.Execute(two, one));
			Assert.AreEqual(one, div.Execute(two, two));
			Assert.AreEqual(two, div.Execute(one, half));
			Assert.AreEqual(new Float(3), div.Execute(oneHalf, half));
			Assert.AreEqual(half, div.Execute(one, two));
		}


		[Test]
		public void ErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => div.Execute(new Integer(1), new String("a")));
			Assert.Throws<System.InvalidOperationException>(() => div.Execute(new Integer(1), new Boolean(true)));
			Assert.Throws<System.InvalidOperationException>(() => div.Execute(new Integer(1), new Float(0.0f)));

			Assert.Throws<System.InvalidOperationException>(() => div.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => div.Execute(new Boolean(true), new Boolean(false)));
		}
	}
}
