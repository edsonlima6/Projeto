using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class FuncionalidadePermissao
    {
        #region Atributos
        public int IdFuncionalidadePermissao { get; set; }
        public string Nome { get; set; }
        public int TipoFuncionalidade { get; set; }
        public int IdFuncionalidade { get; set; }
        public virtual Funcionalidade Funcionalidade { get; set; }
        public virtual ICollection<PermissaoGrupoUsuario> PermissaoGrupoUsuarios { get; set; }
        #endregion

        #region Construtores
        public FuncionalidadePermissao()
        {
            this.PermissaoGrupoUsuarios = new List<PermissaoGrupoUsuario>();
        }
        #endregion

        #region Metodos
        #endregion
  
    }
}
