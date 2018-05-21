using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP1_assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNP1_assignment.Controllers
{
    public class MoviesController : Controller
    {

        private VIACinemaContext db = new VIACinemaContext();
        
        public IActionResult Index()
        {
            var movie = db.Movies.FirstOrDefault();
            return View(movie);
        }
    }
}