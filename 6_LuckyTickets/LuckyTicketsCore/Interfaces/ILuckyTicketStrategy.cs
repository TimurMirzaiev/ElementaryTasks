using _6_LuckyTickets.LuckyTicketsCore.Model;

namespace _6_LuckyTickets.LuckyTicketsCore.Interfaces
{
    public interface ILuckyTicketStrategy
    {
        bool IsLuckyTicket(Ticket ticket);
    }
}
