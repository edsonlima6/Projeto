using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBI_MVC.Models
{
    public class Cliente : IClienteModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
    }
}