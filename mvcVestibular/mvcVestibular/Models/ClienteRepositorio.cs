using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcVestibular.Models
{
    public class ClienteRepositorio
    {
        private List<Cliente> clientes;

        public ClienteRepositorio()
        {
            clientes = new List<Cliente>();

            for (int i = 0; i < 10; i++)
            {
                clientes.Add(new Cliente{
                    Id = i,
                    Idade = 18+i,
                    Nome = "Nome " + i.ToString() 
                });
            }

        }


        public void Insert(Cliente cliente){
            if (!clientes.Exists(c => c.Id == cliente.Id))
                clientes.Add(cliente);
            else
                throw new Exception("Cliente ja existe");
        }

        public IList<Cliente> GetAll()
        {
            return clientes;
        }

        
    }
}