using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApi.Dtos;
using TicketApi.Dtos.Ticket;
using TicketApi.Models;

namespace TicketApi.Mappers
{
    public static class TicketMappers
    {
        public static TicketDto MapToTicketDto(this Ticket ticketModel)
        {
            return new TicketDto
            {
                Id = ticketModel.Id,
                Title = ticketModel.Title,
                Description = ticketModel.Description
            };
        }

        public static Ticket MapToTicketModel(this CreateTicketDto createTicketDto)
        {
            return new Ticket
            {
                Title = createTicketDto.Title,
                Description = createTicketDto.Description
            };
        }

    }
}