using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcVestibular.Controllers
{
    public class ErrorPageController : Controller
    {
        //
        // GET: /ErrorPage/

        public ActionResult PageNotFound()
        {
            return View();
        }

    }
}
