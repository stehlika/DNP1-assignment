using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DNP1_assignment.Models
{
    public class Movie
    {
        public Movie(MovieService.MovieServiceModel serviceModel)
        {
            Id = serviceModel.id;
            Title = serviceModel.title;
            Release_date = serviceModel.release_date;
            Adult = serviceModel.adult;
            Description = serviceModel.overview;
            Origin = serviceModel.original_language;
            Poster_path = serviceModel.poster_path;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Release_date { get; set; }

        public bool Adult { get; set; }

        public string Description { get; set; }

        public string Origin { get; set; }

        public string Poster_path { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}
