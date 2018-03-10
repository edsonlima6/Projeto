using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Comissao
    {
        #region Atributos

        public int IdComissao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Percentual { get; set; }
        public Nullable<int> Tipo { get; set; }
        public System.DateTime DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public string Ativo { get; set; }
        public virtual ICollection<ComissaoUsuario> ComissaoUsuarios { get; set; }
        #endregion

        #region Construtores
        public Comissao()
        {
            this.ComissaoUsuarios = new List<ComissaoUsuario>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
