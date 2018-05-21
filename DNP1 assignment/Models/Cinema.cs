using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Cinema
    {
  
        [Key]public string Name { get; set; }
        public List<Hall> Halls { get; set; }

    }
}
 