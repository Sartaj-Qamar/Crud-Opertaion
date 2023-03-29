using E_Ticket.Data;
using E_Ticket.Data.Services;
using E_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
