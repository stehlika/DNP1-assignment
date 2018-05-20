using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DNP1_assignment.Models
{
    public class Movie
    {

        [Required]
        public int Id { get; set; }
        [MinLength(2)] [MaxLength(50)] public string Name { get; set; }
        public DateTime releaseDate { get; set; }
        public int length { get; set; }
        public int miminalAge { get; set; }
        public string description { get; set }
        public string origin { get; set; }
    }
}
