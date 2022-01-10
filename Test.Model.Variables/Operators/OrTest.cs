using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class OrTest
	{
		Or or = new Or();

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void Test()
		{
			Boolean t = true;
			Boolean f = false;

			Assert.AreEqual(t, or.Execute(t, t));
			Assert.AreEqual(t, or.Execute(t, f));
			Assert.AreEqual(t, or.Execute(f, t));
			Assert.AreEqual(f, or.Execute(f, f));
		}


		[Test]
		public void ErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => or.Execute(new Integer(0), new Integer(1)));
			Assert.Throws<System.InvalidOperationException>(() => or.Execute(new Float(0), new Float(1)));
			Assert.Throws<System.InvalidOperationException>(() => or.Execute(new String("a"), new String("b")));

			Assert.Throws<System.InvalidOperationException>(() => or.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => or.Execute(new Float(0), new String("b")));
		}
	}
}
