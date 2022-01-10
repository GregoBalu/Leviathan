using Model.Variables.Operators;
using Model.Variables.Variables;
using Model.Variables.Statement;
using NUnit.Framework;

namespace Test.Model.Variables.Statements
{
	public class UnaryStatementTest
	{
		private VariableTable varTable = new VariableTable();

		private readonly VariableName tn = new VariableName("test", "t");
		private readonly Boolean t = true;

		private readonly VariableName fn = new VariableName("test", "f");
		private readonly Boolean f = false;

		private readonly VariableName minusOneIntn = new VariableName("test", "minusOneInt");
		private readonly Integer minusOneInt = new Integer(-1);
		private readonly VariableName zeroIntn = new VariableName("test", "zeroInt");
		private readonly Integer zeroInt = new Integer(0);
		private readonly VariableName oneIntn = new VariableName("test", "oneInt");
		private readonly Integer oneInt = new Integer(1);
		private readonly VariableName twoIntn = new VariableName("test", "twoInt");
		private readonly Integer twoInt = new Integer(2);

		private readonly VariableName minusOneFloatn = new VariableName("test", "minusOneFloat");
		private readonly Float minusOneFloat = new Float(-1.0f);
		private readonly VariableName zeroFloatn = new VariableName("test", "zeroFloat");
		private readonly Float zeroFloat = new Float(0.0f);
		private readonly VariableName halfFloatn = new VariableName("test", "halfFloat");
		private readonly Float halfFloat = new Float(0.5f);
		private readonly VariableName oneFloatn = new VariableName("test", "oneFloat");
		private readonly Float oneFloat = new Float(1.0f);
		private readonly VariableName oneHalfFloatn = new VariableName("test", "oneHalfFloat");
		private readonly Float oneHalfFloat = new Float(1.5f);

		[SetUp]
		public void Setup()
		{
			varTable = new VariableTable();
			varTable[tn] = t;
			varTable[fn] = f;

			varTable[minusOneIntn] = minusOneInt;
			varTable[zeroIntn] = zeroInt;
			varTable[oneIntn] = oneInt;
			varTable[twoIntn] = twoInt;

			varTable[minusOneFloatn] = minusOneFloat;
			varTable[zeroFloatn] = zeroFloat;
			varTable[halfFloatn] = halfFloat;
			varTable[oneFloatn] = oneFloat;
			varTable[oneHalfFloatn] = oneHalfFloat;
		}

		[Test]
		public void UnaryNegateTest()
		{
			Negate neg = new Negate();
			
			UnaryStatement negT = new UnaryStatement(neg, tn);
			UnaryStatement negF = new UnaryStatement(neg, fn);

			Assert.AreEqual(f, negT.Evaluate(varTable));
			Assert.AreNotEqual(negF.Evaluate(varTable), negT.Evaluate(varTable));

			Assert.AreEqual(t, new UnaryStatement(neg, new TemporaryVariable(ref varTable, negT.Evaluate(varTable))).Evaluate(varTable));
		}

		[Test]
		public void UnaryNegativeTest()
		{
			Negative op = new Negative();

			Assert.AreEqual(zeroInt, new UnaryStatement(op, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(minusOneInt, new UnaryStatement(op, oneIntn).Evaluate(varTable));

			Assert.AreEqual(zeroFloat, new UnaryStatement(op, zeroFloatn).Evaluate(varTable));
			Assert.AreEqual(minusOneFloat, new UnaryStatement(op, oneFloatn).Evaluate(varTable));
		}

		[Test]
		public void UnaryIncrementTest()
		{
			Increment op = new Increment();

			Assert.AreEqual(twoInt, new UnaryStatement(op, oneIntn).Evaluate(varTable));

			Assert.AreEqual(zeroInt, new UnaryStatement(op, minusOneIntn).Evaluate(varTable));

			Assert.AreEqual(twoInt, new UnaryStatement(op, new TemporaryVariable(ref varTable, new UnaryStatement(op, zeroIntn).Evaluate(varTable)) ).Evaluate(varTable) );
		}

		[Test]
		public void UnaryDecrementTest()
		{
			Decrement op = new Decrement();

			Assert.AreEqual(zeroInt, new UnaryStatement(op, oneIntn).Evaluate(varTable));
			Assert.AreEqual(minusOneInt, new UnaryStatement(op, zeroIntn).Evaluate(varTable));

			Assert.AreEqual(zeroInt, new UnaryStatement(op, new TemporaryVariable(ref varTable, new UnaryStatement(op, twoIntn).Evaluate(varTable)) ).Evaluate(varTable) );
		}

	}
}
