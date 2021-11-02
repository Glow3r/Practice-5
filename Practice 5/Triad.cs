using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    public class Triad
    {
        public Triad(int first = 1, int second = 1, int third = 1)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int First { get; private set; }
        public int Second { get; private set; }
        public int Third { get; private set; }

        public Triad Add(int summand = 1)
        {
            return new Triad(First + summand, Second + summand, Third + summand);
        }

        public Triad Add(Triad triad)
        {
            return new Triad(First + triad.First, Second + triad.Second, Third + triad.Third);
        }

        public Triad Multiply(int multiplier = 2)
        {
            return new Triad(First * multiplier, Second * multiplier, Third * multiplier);
        }

        public bool AreEqual() => First == Second && Second == Third;
    }
}
