using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieRepository" in both code and config file together.
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext db = new MovieContext();
        public Movie DeleteMovie(int id)
        {
            Movie movie = new Movie();
            try
            {
                movie= db.Movies.Find(id);
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return movie;
        }

        public Movie GetMovie(int id)
        {
            return db.Movies.Find(id);
        }

        public List<Movie> GetMovies()
        {
            return db.Movies.ToList();
        }

        public Movie SaveMovie(Movie movie)
        {
            try
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return movie;
        }

        public Movie UpdateMovie(Movie movie)
        {
            try
            {
                db.Entry(movie).State= System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return movie;
        }
    }
}
