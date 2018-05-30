using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models.Forms
{
    public class BookingForm
    {
        [Required]
        public ICollection<String> checkboxes { set; get; }
        [Required,StringLength(16)]
        public string CardNumber { get; set; }
        [Required]
        public int CardExpirationMonth { get; set; }
        [Required]
        public int CardExpirationYear { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, StringLength(3)]
        public string Cvs { get; set; }
        public bool PaymentCheck { get; set; }


    }
}

