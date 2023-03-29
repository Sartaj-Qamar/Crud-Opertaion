using E_Ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.Controllers
{
   
    public class CinemasContoller : Controller
    {
        private readonly AppDbContext _context;
        public CinemasContoller(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
