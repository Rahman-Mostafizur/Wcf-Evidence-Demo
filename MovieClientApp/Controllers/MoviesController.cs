using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieClientApp.MovireServiceRef;

namespace MovieClientApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();

            var movieList = client.GetMovies();
            client.Close();

            return View(movieList);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();

            var movie = client.GetMovie(id);
            client.Close();

            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                MovieRepositoryClient client = new MovieRepositoryClient();
                client.Open();

                 movie = client.SaveMovie(movie);
                client.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(movie);
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();

            var movie = client.GetMovie(id);
            client.Close();

            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                MovieRepositoryClient client = new MovieRepositoryClient();
                client.Open();

                movie = client.UpdateMovie(movie);
                client.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(movie);
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();

            var movie = client.GetMovie(id);
            client.Close();

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
           
            try
            {
                MovieRepositoryClient client = new MovieRepositoryClient();
                client.Open();

                 client.DeleteMovie(id);
                client.Close();

                
            }
            catch
            {
            }
            return RedirectToAction("Index");
        }
    }
}
