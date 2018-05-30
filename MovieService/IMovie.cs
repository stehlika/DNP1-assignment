using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    [ServiceContract]
    public interface IMovie
    {
        [OperationContract]
        MovieServiceModel GetMovie(string movieName);
        Task<MovieServiceModel> GetMovieAsync(string movieName); 
    }

    [DataContract]
    public class MovieServiceModel
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string release_date { get; set; }
        [DataMember]
        public bool adult { get; set; }
        [DataMember]
        public string overview { get; set; }
        [DataMember]
        public string original_language { get; set; }
        [DataMember]
        public string poster_path { get { return this.url; } set { this.url = $"https://image.tmdb.org/t/p/w500{value}"; } }

        private string url;
    }
}
