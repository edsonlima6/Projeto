using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class ProdutoFornecedor
    {
        #region Atributos
        public int IdProdutoFornecedor { get; set; }
        public System.DateTime DataPrimeiroFornecimento { get; set; }
        public Nullable<System.DateTime> DataUltimoFornecimento { get; set; }
        public int Periodo { get; set; }
        public bool Ativo { get; set; }
        public int IdFornecedor { get; set; }
        public int IdProduto { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Produto Produto { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
        
    }
}
