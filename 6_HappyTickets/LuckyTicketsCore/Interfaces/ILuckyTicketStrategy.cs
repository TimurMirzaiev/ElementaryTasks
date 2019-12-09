using _6_HappyTickets.HappyTicketsCore.Model;

namespace _6_HappyTickets.LuckyTicketsCore.Interfaces
{
    public interface ILuckyTicketStrategy
    {
        bool IsLuckyTicket(Symbol<char>[] symbols);
    }
}
