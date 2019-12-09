using _6_HappyTickets.HappyTicketsCore.Model;
using _6_HappyTickets.LuckyTicketsCore.Interfaces;
using System;

namespace _6_HappyTickets.HappyTicketsCore.Strategy
{
    public class MoscowStrategy : ILuckyTicketStrategy
    {

        public bool IsLuckyTicket(Symbol<char>[] symbols)
        {
            //todo fluent validator 
            //if array is correct //all symbols are digits, array length is even

            int[] digits = GetDigitsFromChars(symbols);

            int sumOfFirstHalf = 0;
            int sumOfSecondHalf = 0;

            for (int i = 0; i < digits.Length / 2; i++)
            {
                sumOfFirstHalf += digits[i];
            }

            for (int i = digits.Length / 2; i < digits.Length; i++)
            {

                sumOfSecondHalf += digits[i];
            }

            return sumOfFirstHalf == sumOfSecondHalf;
        }

        private int[] GetDigitsFromChars(Symbol<char>[] symbols)
        {
            int[] digits = new int[symbols.Length];

            try
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    digits[i] = Convert.ToInt32(symbols[i].Data);
                }

                return digits;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
