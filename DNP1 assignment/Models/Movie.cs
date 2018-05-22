using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DNP1_assignment.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)] 
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int Length { get; set; }

        public int MinimalAge { get; set; }

        public string Description { get; set; }

        public string Origin { get; set; }

        public ICollection<Performance> Performances { get; set; }

    }
}
