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
            if (ModelState.IsValid)
            {
                var lastClientId = clienteRepositorio.GetAll().OrderByDescending(cli => cli.Id).FirstOrDefault().Id;
                cliente.Id = lastClientId + 1;
                clienteRepositorio.Insert(cliente);
                TempData["Mensagem"] = "Usuario incluido com sucesso";
                var clientes = clienteRepositorio.GetAll();
                return View("Index", clientes);
            }
            else
            {
                return View();
            }
             
        }


        public ActionResult Update(int id)
        {
            
            var cli = clienteRepositorio.GetDataById(id);

            return View(cli);
        }

        [HttpPost]
        public ActionResult Update(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteRepositorio.Update(cliente);
                TempData["Mensagem"] = "Usuario atualizado com sucesso";
                var clientes = clienteRepositorio.GetAll();
                return View("Index", clientes);
            }
            else
            {
                return View(cliente);
            }
        }


        public ActionResult Delete(int id)
        {
            var cli = clienteRepositorio.GetDataById(id);
            
            return View(cli);
        }

        [HttpPost] //[HttpPost, ActionName="Delete"] //
        public ActionResult Delete(Cliente cliente)
        {
            clienteRepositorio.Delete(cliente);
            TempData["Mensagem"] = "Usuario excluido com sucesso";
            var clientes = clienteRepositorio.GetAll();
            return View("Index", clientes);
        }









    }
}
