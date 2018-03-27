using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBI_MVC.Models
{
    public class UsuarioVM
    {
        [Required(ErrorMessage ="E-MAIL É OBRIGATÓRIO")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "SENHA É OBRIGATÓRIO")]
        public string Senha { get; set; }
    }
}