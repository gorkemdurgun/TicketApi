using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicketApi.Data;

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
            var tickets = _context.Ticket.ToList();
            return Ok(tickets);
        }
    }
}