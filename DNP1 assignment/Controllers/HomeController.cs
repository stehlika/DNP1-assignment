using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNP1_assignment.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using DNP1_assignment.Models.Forms;

namespace DNP1_assignment.Controllers
{
    public class HomeController : Controller
    {
            private int movieClicked;
            private readonly VIACinemaContext _context;

            public HomeController(VIACinemaContext context)
            {
                _context = context;
            }

            // GET: Movies
            public async Task<IActionResult> Index()
            {
                return View(await _context.Movies.ToListAsync());
            }

            
            public async Task<IActionResult> BookNow(int? id) 
            {
                if (id == null)
                {
                    return NotFound();
                }

                var movie = await _context.Movies.SingleOrDefaultAsync(m => m.Id == id);
                if (movie == null)
                {
                    return NotFound();
                }
            //return View(movie);
                movieClicked =(int) id;
                return View(await _context.Seats.Where(S =>  S.Performance.Id==id).ToListAsync());
            }
        

            private bool MovieExists(int id)
            {
                return _context.Movies.Any(e => e.Id == id);
            }

        public async Task<IActionResult> PaymentForm()
            {

            var collection = Request.Form;
            BookingForm bookingForm = new BookingForm();
            bookingForm.checkboxes = collection["checkedItems"];
            bookingForm.Name = collection["firstName"];
            bookingForm.CardNumber = collection["cardNumber"];
            bookingForm.CardExpirationYear = Int16.Parse(collection["expYear"]);
            bookingForm.CardExpirationMonth = Int16.Parse(collection["expMonth"]);
            bookingForm.Cvs = collection["cvs"];
            PaymentService.PaymentClient paymentClient = new PaymentService.PaymentClient();
            Task<bool> isValid = paymentClient.ValidateCardAsync(new PaymentService.Card
            {
                CardExpirationMonth = bookingForm.CardExpirationMonth,
                CardExpirationYear = bookingForm.CardExpirationYear,
                CardNumber = bookingForm.CardNumber,
                Name = bookingForm.Name,
                Cvs = bookingForm.Cvs
            });

            //tuto je vysledok z toho
            bool correctPayment = isValid.Result;
            bookingForm.PaymentCheck = correctPayment;
            _context.Update(_context.Seats.Where(S => S.Performance.Id == movieClicked));
            //ServiceReference1.Service1Client paymentService = new ServiceReference1.Service1Client();*/
            return View(bookingForm);
        }

    }

}
