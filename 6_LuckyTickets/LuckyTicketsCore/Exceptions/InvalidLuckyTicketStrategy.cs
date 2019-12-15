using System;
using System.Collections.Generic;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore.Exceptions
{
    [Serializable]
    public class InvalidLuckyTicketStrategy : Exception
    {
        public InvalidLuckyTicketStrategy() { }

        public InvalidLuckyTicketStrategy(string message) : base(message) { }

        public InvalidLuckyTicketStrategy(string message, Exception inner) : base(message, inner) { }

        protected InvalidLuckyTicketStrategy(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
