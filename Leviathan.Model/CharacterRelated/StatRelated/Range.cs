using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.StatRelated
{
    public class Range
    {
        public Int32 Min { get; set; }
        public Int32 Max { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Int32 Value
        {
            get
            {
                Random r = new Random(DateTime.Now.Second + DateTime.Now.Millisecond);
                return r.Next(Min, Max);
            }
        }

        public Range(Int32 min, Int32 max)
        {
            Min = min;
            Max = max;
        }

        public Range(Range r)
        {
            Min = r.Min;
            Max = r.Max;
        }

        public static Range operator+(Range a, Int32 v)
        {
            Range result = new Range(a);
            result.Min += v;
            result.Max += v;

            return result;
        }

        public static Range operator -(Range a, Int32 v)
        {
            Range result = new Range(a);
            result.Min -= v;
            result.Max -= v;

            return result;
        }

        public static Range operator +(Range a, Range b)
        {
            return new Range(a.Min + b.Min, a.Max + b.Max);
        }

        public static Range operator -(Range a, Range b)
        {
            return new Range(a.Min - b.Min, a.Max - b.Max);
        }

        public static explicit operator Range(Int32 value)
        {
            return new Range(value, value);
        }

        public override string ToString()
        {
            return Min.ToString() + "-" + Max.ToString();
        }
    }
}
