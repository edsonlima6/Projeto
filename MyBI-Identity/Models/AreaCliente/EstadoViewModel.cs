using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBI_Identity.Models.AreaCliente
{
    public class EstadoViewModel
    {
        public EstadoViewModel()
        {

        }

        public int IdEstado { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}