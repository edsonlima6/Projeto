using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Condicao
    {
        #region Atributos

        public int IdCondicao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoCondicao { get; set; }
        public int Ativo { get; set; }
        public virtual ICollection<CondicaoCliente> CondicaoClientes { get; set; }
        #endregion

        #region Construtores
        public Condicao()
        {
            this.CondicaoClientes = new List<CondicaoCliente>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
