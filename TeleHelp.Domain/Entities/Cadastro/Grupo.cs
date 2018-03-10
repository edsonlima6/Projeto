using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Grupo
    {
        #region Atributos
        public int IdGrupo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
        #endregion

        #region Construtores
        public Grupo()
        {
            this.GrupoUsuarios = new List<GrupoUsuario>();
        }
        #endregion

        #region Metodos
        #endregion
   
    }
}
