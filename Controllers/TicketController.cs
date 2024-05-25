using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicketApi.Data;
using TicketApi.Dtos;
using TicketApi.Dtos.Ticket;
using TicketApi.Mappers;

namespace TicketApi.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly ApplicationDBContext _context;

        public TicketController(ApplicationDBContext applicationDBContext)
        {
            _context = applicationDBContext;
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = _context.Ticket.ToList().Select(t=> t.MapToTicketDto());
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public IActionResult GetTicketById([FromRoute] int id)
        {
            var ticket = _context.Ticket.FirstOrDefault(t => t.Id == id);
            return Ok(ticket);
        }

        [HttpPost]
        public IActionResult CreateTicket([FromBody] CreateTicketDto createTicketDto)
        {
            var ticketModel = createTicketDto.MapToTicketModel();
            _context.Ticket.Add(ticketModel);
            _context.SaveChanges();
            return Ok();
        }
    }
}