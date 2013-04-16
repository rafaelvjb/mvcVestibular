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
        private ClienteRepositorio clienteRepositorio;
        public ClienteController()
        {
            clienteRepositorio = RepositorioFactory.InstanciarRepositorio();
        }

        public ActionResult Index()
        {
            var clientes = clienteRepositorio.GetAll();
            return View(clientes);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Cliente cliente)
        {
            var lastClientId = clienteRepositorio.GetAll().OrderByDescending(cli => cli.Id).FirstOrDefault().Id;
            cliente.Id = lastClientId + 1;
            clienteRepositorio.Insert(cliente);

            var clientes = clienteRepositorio.GetAll();
            
            return View("Index",clientes);
        }
    }
}
