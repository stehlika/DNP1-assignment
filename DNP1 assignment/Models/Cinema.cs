using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Cinema
    {
  
        public int Id { get; set; }

        public string Name { get; set; }

        [MinLength(2)]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        public ICollection<Hall> Halls { get; set; }

    }
}
 