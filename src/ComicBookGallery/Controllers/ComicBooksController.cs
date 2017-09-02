using System;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    return Redirect("/");
            //    //return new RedirectResult("/");
            //}

            //return new ContentResult()
            //{
            //    Content = "Hello"
            //};
        }
    }
}