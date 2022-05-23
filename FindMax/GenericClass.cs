using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum_Generics.FindMax
{
    public class GenericClass<T> where T : IComparable
    {
        public T first , second , third ;
        public GenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T Maximum(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                return first;
            }
        }
        public T TestMax()
        {
            T max = GenericClass<T>.Maximum(this.first, this.second, this.third);
            return max;
        }
    }
}
