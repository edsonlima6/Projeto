using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBISolutions.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }

        
        public string Login { get; set; }

        [Required(ErrorMessage ="Senha Inválida")]
        [MaxLength(12,ErrorMessage ="Senha não pode ser superior a 12 digitos")]
        [MinLength(8, ErrorMessage = "Senha não pode ser inferior a 8 digitos")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirmação de senha inválida.")]
        [MaxLength(12, ErrorMessage = "Senha não pode ser superior a 12 digitos")]
        [MinLength(8, ErrorMessage = "Senha não pode ser inferior a 8 digitos")]
        [Display(Name ="Confirmação de senha")]
        public string SenhaRepetida { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public byte[] Foto { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }



    }
}