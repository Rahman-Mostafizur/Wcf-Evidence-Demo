using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    [DataContract]
    public class Movie
    {
        [Key]
        [DataMember(Order = 0)]
        public int Id { get; set; }
        [DataMember(Order = 1)]
        public String Title { get; set; }
        [DataMember(Order = 2)]
        public string Director { get; set; }
        [DataMember(Order = 03)]
        public float Duration { get; set; }
        [DisplayName("Release Date")]
        public DateTimeOffset? ReleaseDate { get; set; }=DateTimeOffset.Now;
    }


    internal class MovieContext : DbContext
    {
        internal MovieContext():base("MovieContext")
        {
        }


        internal DbSet<Movie> Movies { get; set; }
    }


}
