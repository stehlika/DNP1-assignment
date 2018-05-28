using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNP1_assignment.Models;

namespace DNP1_assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PaymentService.PaymentClient paymentClient = new PaymentService.PaymentClient();


            Task<bool> isValid = paymentClient.ValidateCardAsync(new PaymentService.Card
            {
                CardExpirationMonth = 12,
                CardExpirationYear = 2019,
                CardNumber = "1235123454326543",
                Name = "niekto",
                Cvs = "323"
            });

            //tuto je vysledok z toho
            bool correctPayment = isValid.Result;
            //ServiceReference1.Service1Client paymentService = new ServiceReference1.Service1Client();

             ViewData["Message"] = "smt" + correctPayment;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
