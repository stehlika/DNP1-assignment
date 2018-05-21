using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Hall
    {
        public Cinema Cinema { get; set; }

        [Key]
        public string Name { get; set; }

        public List<Performance> Performances { get; set; }

        public Seat[][] Seats { get; set; }
    }
}
