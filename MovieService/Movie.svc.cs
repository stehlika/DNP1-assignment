using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieService
{
    public class Movie : IMovie
    {
        private static readonly HttpClient client = new HttpClient();

        public MovieServiceModel GetMovie(string movieName)
        {
            Task<MovieServiceModel> movie = GetMovieAsync(movieName);

            return movie.Result;
        }


        public async Task<MovieServiceModel> GetMovieAsync(string movieName)
        {
            MovieServiceModel movie = new MovieServiceModel();
            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://api.themoviedb.org/3/search/movie?api_key=b97edb3572a6a9f660d0b90dc10453b6&query={movieName}");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();

                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(stringResult);

                movie = rootObject.results.First();
            }
            catch (ArgumentNullException)
            {
               
            }

            return movie;
        }
    }


    public class RootObject
    {
        public int total_results { get; set; }
        public ICollection<MovieServiceModel> results { get; set; }
    }
}
