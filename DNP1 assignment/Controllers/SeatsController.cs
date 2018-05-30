using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DNP1_assignment.Models;

namespace DNP1_assignment.Controllers
{
    public class SeatsController : Controller
    {
        private readonly VIACinemaContext _context;

        public SeatsController(VIACinemaContext context)
        {
            _context = context;
        }

        // GET: Seats
        public async Task<IActionResult> Index()
        {
            Performance performance = _context.Performances.Where(S => S.Movie.Id ==1).First();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Seat seat = new Seat();
                    seat.XPosition = i;
                    seat.YPosition = j;
                    seat.Performance = performance;
                    _context.Add(seat);
                }
            }
            await _context.SaveChangesAsync();
            return View(await _context.Seats.ToListAsync());
        }

    }
}
