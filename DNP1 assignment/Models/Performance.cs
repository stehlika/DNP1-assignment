using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP1_assignment.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public Hall Hall { get; set; }

        public string Language { get; set; }

        public string Subtitles { get; set; }

    }
}
