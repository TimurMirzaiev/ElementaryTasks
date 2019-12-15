using _6_LuckyTickets.LuckyTicketsCore.Interfaces;
using System;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore.Model
{
    public class Ticket : ITicket<int>
    {
        private int[] _sequence { get; set; }
        private const int DIVIDER = 10;

        public int Length
        {
            get
            {
                return _sequence.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return _sequence[index];
            }
            set
            {
                _sequence[index] = value;
            }
        }

        public Ticket(int rank, int number)
        {
            _sequence = new int[rank];

            int integer = 0;
            int index = _sequence.Length - 1;
            int rest;

            do
            {
                integer = number / DIVIDER;

                if (number != 0)
                {
                    rest = number % DIVIDER;
                    number -= rest;
                    number /= DIVIDER;
                    _sequence[index] = rest;
                    index--;
                }

            } while (integer != 0);

            while (index >= 0)
            {
                _sequence[index] = 0;
                index--;
            }
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < _sequence.Length; i++)
            {
                res.Append(string.Format("{0} ", _sequence[i]));
            }

            return res.ToString();
        }

        private void FillSequence(int rank, int number)
        {

        }
    }
}