using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Produto
    {
        #region Atributos
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int TipoProduto { get; set; }
        public Nullable<int> TipoLinhaProduto { get; set; }
        public string Modelo { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<EstoquePacoteProduto> EstoquePacoteProdutoes { get; set; }
        public virtual ICollection<EstoqueProduto> EstoqueProdutoes { get; set; }
        public virtual ICollection<NotaFiscalImposto> NotaFiscalImpostoes { get; set; }
        public virtual ICollection<OrcamentoVenda> OrcamentoVendas { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProdutoes { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual ICollection<ServicoProduto> ServicoProdutoes { get; set; }
        #endregion

        #region Construtores
        public Produto()
        {
            this.EstoquePacoteProdutoes = new List<EstoquePacoteProduto>();
            this.EstoqueProdutoes = new List<EstoqueProduto>();
            this.NotaFiscalImpostoes = new List<NotaFiscalImposto>();
            this.OrcamentoVendas = new List<OrcamentoVenda>();
            this.PedidoProdutoes = new List<PedidoProduto>();
            this.ProdutoFornecedors = new List<ProdutoFornecedor>();
            this.ServicoProdutoes = new List<ServicoProduto>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
