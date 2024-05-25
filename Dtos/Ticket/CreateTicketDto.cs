using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.Dtos.Ticket
{
    public class CreateTicketDto
    {
         public string Title { get; set; }
        public string Description { get; set; }
    }
}