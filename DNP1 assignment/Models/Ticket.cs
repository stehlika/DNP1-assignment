using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Ticket
    {
        public double price { get; set; }

        public Seat Seat { get; set; }

        public bool Discount { get; set; }
    }
}
