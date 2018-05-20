using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Hall> Halls { get; set; }

    }
}
