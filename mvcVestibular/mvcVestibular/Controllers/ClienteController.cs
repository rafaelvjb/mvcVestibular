using mvcVestibular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcVestibular.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            var clientes = RepositorioFactory.InstanciarRepositorio().GetAll()[0];
            return View(clientes);
        }

    }
}
