using System.Collections.Generic;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Unidade
    {
        #region Atributos
        public int IdUnidade { get; set; }
        public string Codigo { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProdutoes { get; set; }
        //public virtual ICollection<UnidadeCliente> UnidadeClientes { get; set; }

        #endregion

        #region Construtores
        public Unidade()
        {
            this.PedidoProdutoes = new List<PedidoProduto>();
            //this.UnidadeClientes = new List<UnidadeCliente>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
