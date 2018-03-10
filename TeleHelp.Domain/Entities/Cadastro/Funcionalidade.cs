using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Funcionalidade
    {
        #region Atributos
        public int IdFuncionalidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public int IdMenu { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<FuncionalidadePermissao> FuncionalidadePermissaos { get; set; }
        #endregion

        #region Construtores
        public Funcionalidade()
        {
            this.FuncionalidadePermissaos = new List<FuncionalidadePermissao>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
