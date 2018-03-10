using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Departamento
    {
        #region Atributos
        public int IdDepartamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ativo { get; set; }
        public virtual ICollection<RepresentanteUsuario> RepresentanteUsuarios { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        #endregion

        #region Construtores
        public Departamento()
        {
            this.RepresentanteUsuarios = new List<RepresentanteUsuario>();
            this.Usuarios = new List<Usuario>();
        }
        #endregion

        #region Metodos
        #endregion
     
    }
}
