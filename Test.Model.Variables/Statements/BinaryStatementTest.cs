using Model.Variables.Operators;
using Model.Variables.Variables;
using Model.Variables.Statement;
using NUnit.Framework;

namespace Test.Model.Variables.Statements
{
	public class BinaryStatementTest
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

		private readonly VariableName emptyn = new VariableName("test", "empty");
		private readonly String empty = "";
		private readonly VariableName an = new VariableName("test", "a");
		private readonly String a = "a";
		private readonly VariableName bn = new VariableName("test", "b");
		private readonly String b = "b";
		private readonly VariableName abn = new VariableName("test", "ab");
		private readonly String ab = "ab";
		private readonly VariableName ban = new VariableName("test", "ba");
		private readonly String ba = "ba";

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

			varTable[emptyn] = empty;
			varTable[an] = a;
			varTable[bn] = b;
			varTable[abn] = ab;
			varTable[ban] = ba;
		}

		[Test]
		public void BinaryPlusTest()
		{
			Plus op = new Plus();

			Assert.AreEqual(twoInt, new BinaryStatement(op, oneIntn, oneIntn).Evaluate(varTable) );
			Assert.AreEqual(zeroInt, new BinaryStatement(op, minusOneIntn, oneIntn).Evaluate(varTable) );

			Assert.AreEqual(oneHalfFloat, new BinaryStatement(op, oneFloatn, halfFloatn).Evaluate(varTable));
			Assert.AreEqual(halfFloat, new BinaryStatement(op, minusOneFloatn, oneHalfFloatn).Evaluate(varTable));

			Assert.AreEqual(b, new BinaryStatement(op, emptyn, bn).Evaluate(varTable));
			Assert.AreEqual(ab, new BinaryStatement(op, an, bn).Evaluate(varTable));
		}

		[Test]
		public void BinaryPlusErrorTest()
		{
			Plus op = new Plus();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, tn).Evaluate(varTable) );
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, abn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroIntn, halfFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryMinusTest()
		{
			Minus op = new Minus();

			Assert.AreEqual(minusOneInt, new BinaryStatement(op, oneIntn, twoIntn).Evaluate(varTable) );
			Assert.AreEqual(twoInt, new BinaryStatement(op, oneIntn, minusOneIntn).Evaluate(varTable));
			Assert.AreEqual(halfFloat, new BinaryStatement(op, oneFloatn, halfFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryMinusErrorTest()
		{
			Minus op = new Minus();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, tn).Evaluate(varTable) );
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, abn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroIntn, halfFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryMultiplyTest()
		{
			Multiply op = new Multiply();

			Assert.AreEqual(new Integer(12), new BinaryStatement(op, 
				new TemporaryVariable(ref varTable, new Integer(3)), 
				new TemporaryVariable(ref varTable, new Integer(4))
				).Evaluate(varTable));
			Assert.AreEqual(oneHalfFloat, new BinaryStatement(
				op, 
				halfFloatn, 
				new TemporaryVariable(ref varTable, new Float(3))
				).Evaluate(varTable));
		}

		[Test]
		public void BinaryMultiplyErrorTest()
		{
			Multiply op = new Multiply();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, tn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, abn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroIntn, halfFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryDivideTest()
		{
			Divide op = new Divide();

			Assert.AreEqual(twoInt, new BinaryStatement(op, twoIntn, oneIntn).Evaluate(varTable));
			Assert.AreEqual(new Float(3.0f), new BinaryStatement(op, oneHalfFloatn, halfFloatn).Evaluate(varTable));

		}

		[Test]
		public void BinaryDivideErrorTest()
		{
			Divide op = new Divide();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, halfFloatn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, an).Evaluate(varTable));
		}

		[Test]
		public void BinaryModuloTest()
		{
			Modulo op = new Modulo();

			Assert.AreEqual(zeroInt, new BinaryStatement(op, oneIntn, oneIntn).Evaluate(varTable));
			Assert.AreEqual(oneInt, new BinaryStatement(op, new TemporaryVariable(ref varTable, new Integer(3)), twoIntn).Evaluate(varTable));
			Assert.AreEqual(halfFloat, new BinaryStatement(op, oneHalfFloatn, oneFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryModuloErrorTest()
		{
			Modulo op = new Modulo();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, halfFloatn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, an).Evaluate(varTable));
		}

		[Test]
		public void BinaryAndTest()
		{
			And op = new And();

			Assert.AreEqual(t, new BinaryStatement(op, tn, tn).Evaluate(varTable) );
			Assert.AreEqual(f, new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, fn, tn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, fn, fn).Evaluate(varTable));
		}

		[Test]
		public void BinaryAndErrorTest()
		{
			And op = new And();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, zeroIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, an, oneFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryOrTest()
		{
			Or op = new Or();

			Assert.AreEqual(t, new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, tn, tn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, fn, fn).Evaluate(varTable));
		}

		[Test]
		public void BinaryOrErrorTest()
		{
			Or op = new Or();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, zeroIntn, oneIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneIntn, halfFloatn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, an).Evaluate(varTable));
		}

		[Test]
		public void BinaryEqualTest()
		{
			Equality op = new Equality();

			Assert.AreEqual(f, new BinaryStatement(op, tn, fn).Evaluate(varTable) );
			Assert.AreEqual(t, new BinaryStatement(op, tn, tn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, an, an).Evaluate(varTable));
		}

		[Test]
		public void BinaryEqualErrorTest()
		{
			Equality op = new Equality();

			Assert.Throws<System.InvalidOperationException> (() => new BinaryStatement(op, tn, ban).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, oneIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(
				op, 
				oneIntn, 
				new TemporaryVariable(ref varTable, new String("1"))
				).Evaluate(varTable));
		}

		[Test]
		public void BinaryInEqualTest()
		{
			InEquality op = new InEquality();

			Assert.AreEqual(t, new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, tn, tn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, an, an).Evaluate(varTable));
		}

		[Test]
		public void BinaryInEqualErrorTest()
		{
			InEquality op = new InEquality();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, ban).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, oneIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, 
				oneIntn,
				new TemporaryVariable(ref varTable, new String("1"))
				).Evaluate(varTable));
		}

		[Test]
		public void BinaryLessTest()
		{
			Less op = new Less();

			Assert.AreEqual(f, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, minusOneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, halfFloatn, zeroFloatn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, zeroFloatn, zeroFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryLessErrorTest()
		{
			Less op = new Less();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, zeroIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, tn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, fn, zeroIntn).Evaluate(varTable));
		}

		[Test]
		public void BinaryLessEqualTest()
		{
			LessEq op = new LessEq();

			Assert.AreEqual(f, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, minusOneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, halfFloatn, zeroFloatn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, zeroFloatn, zeroFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryLessEqualErrorTest()
		{
			LessEq op = new LessEq();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, zeroIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, tn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, fn, zeroIntn).Evaluate(varTable));
		}

		[Test]
		public void BinaryGreaterTest()
		{
			Greater op = new Greater();

			Assert.AreEqual(t, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, minusOneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, halfFloatn, zeroFloatn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, zeroFloatn, zeroFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryGreaterErrorTest()
		{
			Greater op = new Greater();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, zeroIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, tn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, fn, zeroIntn).Evaluate(varTable));
		}

		[Test]
		public void BinaryGreaterEqualTest()
		{
			GreaterEq op = new GreaterEq();

			Assert.AreEqual( t, new BinaryStatement(op, oneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(f, new BinaryStatement(op, minusOneIntn, zeroIntn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, halfFloatn, zeroFloatn).Evaluate(varTable));
			Assert.AreEqual(t, new BinaryStatement(op, zeroFloatn, zeroFloatn).Evaluate(varTable));
		}

		[Test]
		public void BinaryGreaterEqualErrorTest()
		{
			GreaterEq op = new GreaterEq();

			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, zeroIntn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, abn, an).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, tn, fn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, oneFloatn, tn).Evaluate(varTable));
			Assert.Throws<System.InvalidOperationException>(() => new BinaryStatement(op, fn, zeroIntn).Evaluate(varTable));
		}

	}
}
