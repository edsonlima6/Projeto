using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Deposito
    {
        #region Atributos

        public int IdDeposito { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        #endregion

        #region Construtores
        public Deposito()
        {
            this.Clientes = new List<Cliente>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
