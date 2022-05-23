using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum_Generics.FindMax
{
    public class MoreParameters<T> where T : IComparable
    {
        public T[] values;

        public MoreParameters(T[] values)
        {
            this.values = values;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {   
            var sorted= Sort(this.values);
            return sorted[sorted.Length - 1];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.values);
            return max;
        }
        public void PrintMaximum()
        {
            var max = MaxValue(this.values);
            Console.WriteLine("Maximum value : " + max);
        }
    }
}
