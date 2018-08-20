using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBI_Identity.Models.AreaCliente
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage ="Nome é obrigatorio")]
        public string Login { get; set; }

        public string Senha { get; set; }


    }
}