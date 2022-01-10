using Model.Variables.Operators;
using Model.Variables.Variables;
using NUnit.Framework;

namespace Test.Model.Variables.Operators
{
	public class UnaryOperatorTest
	{
		private Boolean _boolTrue = new Boolean(true);
		private Boolean _boolFalse = new Boolean(false);

		private Integer _minusOneInt = new Integer(-1);
		private Integer _zeroInt = new Integer(0);
		private Integer _oneInt = new Integer(1);
		private Integer _twoInt = new Integer(2);

		private Float _minusOneFloat = new Float(-1.0f);
		private Float _zeroFloat = new Float(0.0f);
		private Float _oneFloat = new Float(1.0f);

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void NegateTest()
		{
			Negate op = new Negate();
			Assert.IsTrue(op.Execute(_boolFalse));
			Assert.IsFalse(op.Execute(_boolTrue));
			Assert.IsTrue(op.Execute(op.Execute(_boolTrue)));
		}

		[Test]
		public void NegativeIntTest()
		{
			Negative op = new Negative();

			Assert.AreEqual(_zeroInt, op.Execute(_zeroInt));

			Assert.AreEqual(_minusOneInt, op.Execute(_oneInt));
		}

		[Test]
		public void NegativeFloatTest()
		{
			Negative op = new Negative();

			Assert.AreEqual(_zeroFloat, op.Execute(_zeroFloat));

			Assert.AreEqual(_minusOneFloat, op.Execute(_oneFloat));
		}

		[Test]
		public void IncrementIntTest()
		{
			Increment op = new Increment();

			Integer supposedTwoInt = op.Execute(_oneInt);
			Assert.AreEqual(_twoInt, supposedTwoInt);

			Integer supposedZeroInt = op.Execute(_minusOneInt);
			Assert.AreEqual(_zeroInt, supposedZeroInt);

			Assert.AreEqual(_twoInt, op.Execute(op.Execute(_zeroInt)));
		}


		[Test]
		public void DecrementIntTest()
		{
			Decrement op = new Decrement();

			Assert.AreEqual(_zeroInt, op.Execute(_oneInt));
			Assert.AreEqual(_minusOneInt, op.Execute(_zeroInt));

			Assert.AreEqual(_zeroInt, op.Execute(op.Execute(_twoInt)) );
		}

		[Test]
		public void IncDecIntTest()
		{
			Increment inc = new Increment();
			Decrement dec = new Decrement();

			Assert.AreEqual(_zeroInt, dec.Execute(inc.Execute(_zeroInt)) );
		}
	}
}