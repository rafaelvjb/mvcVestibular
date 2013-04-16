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

        public IList<Cliente> GetAll()
        {
            return clientes;
        }

        public Cliente GetDataById(int id)
        {
            return clientes.FirstOrDefault(data => data.Id == id);
        }

        public void Insert(Cliente cliente)
        { 
            //se cliente já existe nao cria
            if (!clientes.Exists(c => c.Id == cliente.Id))
                clientes.Add(cliente);
            else
                throw new Exception("Cliente ja existe");
        }
        
        public void Update(Cliente clienteUpdate)
        {
            clientes.FirstOrDefault(cli => cli.Id == clienteUpdate.Id).Nome = clienteUpdate.Nome;
            clientes.FirstOrDefault(cli => cli.Id == clienteUpdate.Id).Idade = clienteUpdate.Idade;
        }

        public void Delete(Cliente cliente)
        {
            //se cliente existe deleta
            if (clientes.Exists(c => c.Id == cliente.Id))
                clientes.Remove(cliente);
            else
                throw new Exception("Cliente nao existe");
        }
    }
}