using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviesProNew.Models;

namespace moviesProNew.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/NewMovie
        public ActionResult Index()
        {
            var m1 = new Movie() { Id = 10, mName = "Javan" };
            return View(m1);
            //return View("abcd");


        }
    }
}