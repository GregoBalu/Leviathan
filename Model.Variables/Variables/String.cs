using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
    public  class String : Variable
    {
        private string Value { get; set; }

        public String(string val) : base()
        {
            Value = val;
        }

        public static implicit operator String(string val)
        {
            return new String(val);
        }

        public static String operator +(String first, String second)
        {
            return first.Value + second.Value;
        }

        public override bool Equals(object? obj) => this.Equals(obj as String);
        public bool Equals(String? other)
        {
            if (other is null)
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return Value.Equals(other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
