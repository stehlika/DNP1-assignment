using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public Cinema Cinema { get; set; }

        public string Name { get; set; }

        public ICollection<Performance> Performances { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}
