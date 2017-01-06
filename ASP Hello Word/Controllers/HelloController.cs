using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Hello_Word.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult Hello()
        {
            return View();
        }

    }
}
