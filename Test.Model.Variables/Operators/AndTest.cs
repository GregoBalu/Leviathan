using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class AndTest
	{
		And and = new And();

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void Test()
		{
			Boolean t = true;
			Boolean f = false;

			Assert.AreEqual(t, and.Execute(t, t));
			Assert.AreEqual(f, and.Execute(t, f));
			Assert.AreEqual(f, and.Execute(f, t));
			Assert.AreEqual(f, and.Execute(f, f));
		}


		[Test]
		public void ErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => and.Execute(new Integer(0), new Integer(1)));
			Assert.Throws<System.InvalidOperationException>(() => and.Execute(new Float(0), new Float(1)));
			Assert.Throws<System.InvalidOperationException>(() => and.Execute(new String("a"), new String("b")));

			Assert.Throws<System.InvalidOperationException>(() => and.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => and.Execute(new Float(0), new String("b")));
		}
	}
}
