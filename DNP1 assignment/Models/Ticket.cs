using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public Seat Seat { get; set; }

        public bool Discount { get; set; }
    }
}
