using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_8_Sequences.SequencesCore
{
    class Sequence: IEnumerable<int>
    {
        private IEnumerable<int> _sequence;
        private const int LAST_INT_FIBONACCI_NUMBER = 47;

        private Sequence(IEnumerable<int> enumerable)
        {
            _sequence = enumerable;
        }

        public static IEnumerable<int> GetFibonacciSequence(int from, int to)
        {
            int range = 0;
            int square = 0;
            int number = 0;

            if (from <= to && to >= from && from >=0 && to >= 0)
            {
                while (to > number)
                {
                    range++;
                    square = range * range;
                }

                range -= 1;

                return new Sequence(Enumerable.Range(1, range));
            }
            else
            {
                throw new ArgumentException("Invalid arguments");
            }
        }

        public static IEnumerable<int> GetNumberSequenceSquareLessThan(int n)
        {
            int range = 0;
            int square = 0;
            
            if(n > 0)
            {
                while(square < n)
                {
                    range++;
                    square = range * range;
                }

                range -= 1;

                return new Sequence(Enumerable.Range(1, range));

            }
            else
            {
                throw new ArgumentException("Invalid arguments");
            }
        }

        private int fib(int n)
        {
            if(n <= 1)
            {
                return n;
            }

            return fib(n - 2) + fib(n - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sequence.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            foreach (int num in _sequence)
            {
                yield return num;
            }
        }
    }
}
