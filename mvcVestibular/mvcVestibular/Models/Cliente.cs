﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcVestibular.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            return this.Id == ((Cliente)obj).Id;
        }
    }
}