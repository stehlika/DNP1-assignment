using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    public class Movie : IMovie
    {
        private static readonly HttpClient client = new HttpClient();

        public string GetMovie(string movieName)
        {
            return "ahoj";
        }


        public async Task<string> GetMovieAsync(string movieName)
        {
            var stringResult = "";
            try
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3");
                HttpResponseMessage response = await client.GetAsync($"/search/movie?api_key=b97edb3572a6a9f660d0b90dc10453b6&query={movieName}");
                response.EnsureSuccessStatusCode();

                stringResult = await response.Content.ReadAsStringAsync();
                //var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
            }
            catch (ArgumentNullException)
            {

            }

            return stringResult;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
