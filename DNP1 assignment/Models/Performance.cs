using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Performance
    {
        public DateTime date { get; set; }

        public Movie movie { get; set; }

        public List<Ticket> tickets { get; set; }

        public Hall hall { get; set; }

        public string Language { get; set; }

        public string Subtitles { get; set; }

    }
}
