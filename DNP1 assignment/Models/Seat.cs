
namespace DNP1_assignment.Models
{
    public class Seat
    {
        public int Id { get; set; }

        public Performance Performance { get; set; }

        public Payment Payment { get; set; }

        public int xPosition { get; set; }

        public int yPosition { get; set; }
    }
}
