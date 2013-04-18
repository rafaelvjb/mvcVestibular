using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcVestibular.Models
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
 
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            return this.Id == ((Cliente)obj).Id;
        }
    }
}