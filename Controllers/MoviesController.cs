using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Sherk!" };

            //return view(movie);
            //return Content("hello world!");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction(
                "index", "home", new
                {
                    page = 1,
                    sortby = "name"
                });

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(
                String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}