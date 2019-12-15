using System;
using System.Collections.Generic;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore.Interfaces
{
    public interface ITicket<T>
    {
        T this[int index] { get; set; }
        int Length { get; }
    }
}
