using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class ComparisonTest
	{
		Equality eq = new Equality();
		InEquality neq = new InEquality();
		Less l = new Less();
		LessEq le = new LessEq();
		Greater g = new Greater();
		GreaterEq ge = new GreaterEq();

		private Boolean t = true;
		private Boolean f = false;

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void EqIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(t, eq.Execute(zero, zero));
			Assert.AreEqual(f, eq.Execute(zero, one));
			Assert.AreNotEqual(t, eq.Execute(zero, one));
		}

		[Test]
		public void NeqIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(f, neq.Execute(zero, zero));
			Assert.AreEqual(t, neq.Execute(zero, one));
			Assert.AreNotEqual(f, neq.Execute(zero, one));

			Assert.AreEqual(new Negate().Execute(eq.Execute(zero, zero)), neq.Execute(zero, zero));
			Assert.AreEqual(new Negate().Execute(eq.Execute(zero, one)), neq.Execute(zero, one));
		}

		[Test]
		public void EqFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(t, eq.Execute(zero, zero));
			Assert.AreEqual(f, eq.Execute(zero, one));
			Assert.AreEqual(f, eq.Execute(zero, half));
			Assert.AreNotEqual(t, eq.Execute(zero, one));
		}

		[Test]
		public void NeFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(f, neq.Execute(zero, zero));
			Assert.AreEqual(t, neq.Execute(zero, one));
			Assert.AreEqual(t, neq.Execute(zero, half));
			Assert.AreNotEqual(f, neq.Execute(zero, one));

			Assert.AreEqual(new Negate().Execute(eq.Execute(zero, zero)), neq.Execute(zero, zero));
			Assert.AreEqual(new Negate().Execute(eq.Execute(zero, one)), neq.Execute(zero, one));
		}

		[Test]
		public void EqBooleanTest()
		{
			Assert.AreEqual(t, eq.Execute(t, t));
			Assert.AreEqual(f, eq.Execute(t, f));
			Assert.AreEqual(f, eq.Execute(f, t));
			Assert.AreEqual(t, eq.Execute(f, f));
		}

		[Test]
		public void NeqBooleanTest()
		{
			Assert.AreEqual(f, neq.Execute(t, t));
			Assert.AreEqual(t, neq.Execute(t, f));
			Assert.AreEqual(t, neq.Execute(f, t));
			Assert.AreEqual(f, neq.Execute(f, f));

			Assert.AreEqual(new Negate().Execute(eq.Execute(t, t)), neq.Execute(t, t));
			Assert.AreEqual(new Negate().Execute(eq.Execute(t, f)), neq.Execute(t, f));
		}

		[Test]
		public void EqStringTest()
		{
			String a = "a";
			String b = "b";

			Assert.AreEqual(t, eq.Execute(a, a));
			Assert.AreEqual(f, eq.Execute(a, b));
			Assert.AreEqual(f, eq.Execute(b, a));
			Assert.AreEqual(t, eq.Execute(b, b));
		}

		[Test]
		public void NeqStringTest()
		{
			String a = "a";
			String b = "b";

			Assert.AreEqual(f, neq.Execute(a, a));
			Assert.AreEqual(t, neq.Execute(a, b));
			Assert.AreEqual(t, neq.Execute(b, a));
			Assert.AreEqual(f, neq.Execute(b, b));

			Assert.AreEqual(new Negate().Execute(eq.Execute(a, a)), neq.Execute(a, a));
			Assert.AreEqual(new Negate().Execute(eq.Execute(a, b)), neq.Execute(a, b));
		}

		[Test]
		public void LessIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(f, l.Execute(zero, zero));
			Assert.AreEqual(t, l.Execute(zero, one));
			Assert.AreEqual(f, l.Execute(one, zero));
		}

		[Test]
		public void LessFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(f, l.Execute(zero, zero));
			Assert.AreEqual(t, l.Execute(zero, half));
			Assert.AreEqual(t, l.Execute(zero, one));
			Assert.AreEqual(f, l.Execute(one, one));

			Assert.AreEqual(f, l.Execute(one, zero));
			Assert.AreEqual(f, l.Execute(half, zero));
		}

		[Test]
		public void LessEqIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(t, le.Execute(zero, zero));
			Assert.AreEqual(t, le.Execute(zero, one));
			Assert.AreEqual(t, le.Execute(one, one));
			Assert.AreEqual(f, le.Execute(one, zero));
		}

		[Test]
		public void LessEqFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(t, le.Execute(zero, zero));
			Assert.AreEqual(t, le.Execute(zero, half));
			Assert.AreEqual(t, le.Execute(zero, one));
			Assert.AreEqual(t, le.Execute(one, one));

			Assert.AreEqual(f, le.Execute(one, zero));
			Assert.AreEqual(f, le.Execute(half, zero));
		}

		[Test]
		public void GreaterIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(f, g.Execute(zero, zero));
			Assert.AreEqual(f, g.Execute(zero, one));
			Assert.AreEqual(t, g.Execute(one, zero));
		}

		[Test]
		public void GreaterFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(f, g.Execute(zero, zero));
			Assert.AreEqual(f, g.Execute(zero, half));
			Assert.AreEqual(f, g.Execute(zero, one));
			Assert.AreEqual(f, g.Execute(one, one));
			Assert.AreEqual(t, g.Execute(half, zero));
			Assert.AreEqual(t, g.Execute(one, zero));
		}

		[Test]
		public void GreaterEqIntTest()
		{
			Integer zero = 0;
			Integer one = 1;

			Assert.AreEqual(t, ge.Execute(zero, zero));
			Assert.AreEqual(t, ge.Execute(one, zero));
			Assert.AreEqual(t, ge.Execute(one, one));
			Assert.AreEqual(f, ge.Execute(zero, one));
		}

		[Test]
		public void GreaterEqFloatTest()
		{
			Float zero = 0;
			Float half = 0.5f;
			Float one = 1;

			Assert.AreEqual(t, ge.Execute(zero, zero));
			Assert.AreEqual(t, ge.Execute(half, zero));
			Assert.AreEqual(t, ge.Execute(one, zero));
			Assert.AreEqual(t, ge.Execute(one, one));

			Assert.AreEqual(f, ge.Execute(zero, one));
			Assert.AreEqual(f, ge.Execute(zero, half));
		}

		[Test]
		public void EqErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => eq.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => eq.Execute(new Float(0), new String("b")));
		}

		[Test]
		public void NeqErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => neq.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => neq.Execute(new Float(0), new String("b")));
		}

		[Test]
		public void LessErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => l.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => l.Execute(new Boolean(true), new Boolean(false)));

			Assert.Throws<System.InvalidOperationException>(() => l.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => l.Execute(new Float(0), new String("b")));
		}

		[Test]
		public void LessEqErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => le.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => le.Execute(new Boolean(true), new Boolean(false)));

			Assert.Throws<System.InvalidOperationException>(() => le.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => le.Execute(new Float(0), new String("b")));
		}

		[Test]
		public void GreaterErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => g.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => g.Execute(new Boolean(true), new Boolean(false)));

			Assert.Throws<System.InvalidOperationException>(() => g.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => g.Execute(new Float(0), new String("b")));
		}

		[Test]
		public void GreaterEqErrorTest()
		{
			Assert.Throws<System.InvalidOperationException>(() => ge.Execute(new String("a"), new String("b")));
			Assert.Throws<System.InvalidOperationException>(() => ge.Execute(new Boolean(true), new Boolean(false)));

			Assert.Throws<System.InvalidOperationException>(() => ge.Execute(new Integer(0), new Boolean(false)));
			Assert.Throws<System.InvalidOperationException>(() => ge.Execute(new Float(0), new String("b")));
		}
	}
}
