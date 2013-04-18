using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcVestibular.Controllers
{
    public class ExemploController : Controller
    {
        //
        // GET: /Exemplo/

        //public string SayHello()
        //{
        //    return "Hello World!";
        //}
        public ActionResult SayHello()
        {
            ViewBag.Mensagem = "Mensagem viewbag";
            return View();
        }

    }
}
