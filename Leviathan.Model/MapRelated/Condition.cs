using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leviathan.Model.MapRelated.ConditionRelated;

namespace Leviathan.Model.MapRelated
{
    public class Condition 
    {
        public String Variable { get; set; }

        public Operator Operator { get; set; }

        public Int32 Value { get; set; }


        public Condition()
        {
            Variable = "";
            Operator = Operator.Equals;
            Value = 0;
        }

        public Condition(String s, Operator op, Int32 v)
        {
            Variable = s;
            Operator = op;
            Value = v;
        }

        public static Condition Nothing
        {
            get
            {
                return new Condition();
            }
        }
    
        public Boolean IsTrue(VariableTable history)
        {
            if(Nothing == this)
                return true;

            if (history.Keys.Contains(Variable))
                return Evaluate(history[Variable]);
            else
                return false;
        }

        public static bool operator==(Condition first, Condition second)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(first, second))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)first == null) || ((object)second == null))
            {
                return false;
            }

            return first.Variable == second.Variable && 
                first.Operator == second.Operator && 
                first.Value == second.Value;
        }

        public static bool operator!=(Condition first, Condition second)
        {
            return !(first == second);
        }

        private Boolean Evaluate(Int32 val)
        {
            switch(Operator)
            {
                case Operator.Equals:
                    return val == Value;
                case Operator.Greater_than:
                    return val > Value;
                case Operator.Greater_or_equal_than:
                    return val >= Value;
                case Operator.Less_than:
                    return val < Value;
                case Operator.Less_or_equal_than:
                    return val <= Value;
            }
            throw new NotImplementedException();
        }
    
    }
}
