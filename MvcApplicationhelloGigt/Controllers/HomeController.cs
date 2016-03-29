using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationhelloGigt.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Response.Write("<h1>Hello Git</h1>");
            return View();
        }
        public ActionResult Foo()
        {
            Response.Write("<h1>hello foo</h1>");
            return View();
        }
        public ActionResult Bar()
        {
            Response.Write("<h1>hello foo</h1>");
            return View();
        }
    }
}
