using _6_LuckyTickets.LuckyTicketsCore.Model;
using FluentValidation;

namespace _6_LuckyTickets.LuckyTicketsCore.Validation
{
    public class TicketValidator : AbstractValidator<Ticket>
    {
        public TicketValidator()
        {
            RuleFor(t => t.Length % 2 == 0 && t.Length >= 6);
        }
    }
}
