using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Representante
    {
        #region Atributos
        public int IdRepresentante { get; set; }
        public string RazaoSocial { get; set; }
        public int CNPJ { get; set; }
        public string Endereco { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public Nullable<int> CEP { get; set; }
        public string UF { get; set; }
        public Nullable<int> DDD { get; set; }
        public Nullable<int> Telefone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<RepresentanteUsuario> RepresentanteUsuarios { get; set; }
        #endregion

        #region Construtores
        public Representante()
        {
            this.RepresentanteUsuarios = new List<RepresentanteUsuario>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
