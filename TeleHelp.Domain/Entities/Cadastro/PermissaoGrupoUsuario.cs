using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class PermissaoGrupoUsuario
    {
        #region Atributos
        public int IdPermissaoGrupoUsuario { get; set; }
        public int IdGrupoUsuario { get; set; }
        public int IdFuncionalidadePermissao { get; set; }
        public virtual FuncionalidadePermissao FuncionalidadePermissao { get; set; }
        public virtual GrupoUsuario GrupoUsuario { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
    
    }
}
