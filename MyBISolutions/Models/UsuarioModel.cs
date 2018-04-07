using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBISolutions.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "Login Inválida")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Senha Inválida")]
        [MaxLength(4,ErrorMessage ="máximo de 4 digitos")]
        public string Senha { get; set; }



    }
}