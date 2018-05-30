﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieServiceModel", Namespace="http://schemas.datacontract.org/2004/07/MovieService")]
    public partial class MovieServiceModel : object
    {
        
        private bool adultField;
        
        private int idField;
        
        private string original_languageField;
        
        private string overviewField;
        
        private string poster_pathField;
        
        private string release_dateField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool adult
        {
            get
            {
                return this.adultField;
            }
            set
            {
                this.adultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string original_language
        {
            get
            {
                return this.original_languageField;
            }
            set
            {
                this.original_languageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string overview
        {
            get
            {
                return this.overviewField;
            }
            set
            {
                this.overviewField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string poster_path
        {
            get
            {
                return this.poster_pathField;
            }
            set
            {
                this.poster_pathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string release_date
        {
            get
            {
                return this.release_dateField;
            }
            set
            {
                this.release_dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieService.IMovie")]
    public interface IMovie
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovie/GetMovie", ReplyAction="http://tempuri.org/IMovie/GetMovieResponse")]
        System.Threading.Tasks.Task<MovieService.MovieServiceModel> GetMovieAsync(string movieName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IMovieChannel : MovieService.IMovie, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class MovieClient : System.ServiceModel.ClientBase<MovieService.IMovie>, MovieService.IMovie
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MovieClient() : 
                base(MovieClient.GetDefaultBinding(), MovieClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMovie.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieClient(EndpointConfiguration endpointConfiguration) : 
                base(MovieClient.GetBindingForEndpoint(endpointConfiguration), MovieClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MovieClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MovieClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<MovieService.MovieServiceModel> GetMovieAsync(string movieName)
        {
            return base.Channel.GetMovieAsync(movieName);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMovie))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMovie))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:49990/Movie.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MovieClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMovie);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MovieClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMovie);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMovie,
        }
    }
}
