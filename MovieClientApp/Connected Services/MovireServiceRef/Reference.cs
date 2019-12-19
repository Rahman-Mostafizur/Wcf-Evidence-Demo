﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieClientApp.MovireServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MovieService")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DurationField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public float Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((this.DurationField.Equals(value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovireServiceRef.IMovieRepository")]
    public interface IMovieRepository {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/GetMovies", ReplyAction="http://tempuri.org/IMovieRepository/GetMoviesResponse")]
        System.Collections.Generic.List<MovieClientApp.MovireServiceRef.Movie> GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/GetMovies", ReplyAction="http://tempuri.org/IMovieRepository/GetMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MovieClientApp.MovireServiceRef.Movie>> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/GetMovie", ReplyAction="http://tempuri.org/IMovieRepository/GetMovieResponse")]
        MovieClientApp.MovireServiceRef.Movie GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/GetMovie", ReplyAction="http://tempuri.org/IMovieRepository/GetMovieResponse")]
        System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/SaveMovie", ReplyAction="http://tempuri.org/IMovieRepository/SaveMovieResponse")]
        MovieClientApp.MovireServiceRef.Movie SaveMovie(MovieClientApp.MovireServiceRef.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/SaveMovie", ReplyAction="http://tempuri.org/IMovieRepository/SaveMovieResponse")]
        System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> SaveMovieAsync(MovieClientApp.MovireServiceRef.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/UpdateMovie", ReplyAction="http://tempuri.org/IMovieRepository/UpdateMovieResponse")]
        MovieClientApp.MovireServiceRef.Movie UpdateMovie(MovieClientApp.MovireServiceRef.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/UpdateMovie", ReplyAction="http://tempuri.org/IMovieRepository/UpdateMovieResponse")]
        System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> UpdateMovieAsync(MovieClientApp.MovireServiceRef.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/DeleteMovie", ReplyAction="http://tempuri.org/IMovieRepository/DeleteMovieResponse")]
        MovieClientApp.MovireServiceRef.Movie DeleteMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieRepository/DeleteMovie", ReplyAction="http://tempuri.org/IMovieRepository/DeleteMovieResponse")]
        System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> DeleteMovieAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovieRepositoryChannel : MovieClientApp.MovireServiceRef.IMovieRepository, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieRepositoryClient : System.ServiceModel.ClientBase<MovieClientApp.MovireServiceRef.IMovieRepository>, MovieClientApp.MovireServiceRef.IMovieRepository {
        
        public MovieRepositoryClient() {
        }
        
        public MovieRepositoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieRepositoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieRepositoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieRepositoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MovieClientApp.MovireServiceRef.Movie> GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MovieClientApp.MovireServiceRef.Movie>> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public MovieClientApp.MovireServiceRef.Movie GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
        
        public MovieClientApp.MovireServiceRef.Movie SaveMovie(MovieClientApp.MovireServiceRef.Movie movie) {
            return base.Channel.SaveMovie(movie);
        }
        
        public System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> SaveMovieAsync(MovieClientApp.MovireServiceRef.Movie movie) {
            return base.Channel.SaveMovieAsync(movie);
        }
        
        public MovieClientApp.MovireServiceRef.Movie UpdateMovie(MovieClientApp.MovireServiceRef.Movie movie) {
            return base.Channel.UpdateMovie(movie);
        }
        
        public System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> UpdateMovieAsync(MovieClientApp.MovireServiceRef.Movie movie) {
            return base.Channel.UpdateMovieAsync(movie);
        }
        
        public MovieClientApp.MovireServiceRef.Movie DeleteMovie(int id) {
            return base.Channel.DeleteMovie(id);
        }
        
        public System.Threading.Tasks.Task<MovieClientApp.MovireServiceRef.Movie> DeleteMovieAsync(int id) {
            return base.Channel.DeleteMovieAsync(id);
        }
    }
}