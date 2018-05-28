
using System;

namespace DNP1_assignment.Models
{
    public class Seat
    {
        public int Id { get; set; }

        public Performance Performance { get; set; }

        public Payment Payment { get; set; }

        public int XPosition { get; set; }

        public int YPosition { get; set; }

    }
}
