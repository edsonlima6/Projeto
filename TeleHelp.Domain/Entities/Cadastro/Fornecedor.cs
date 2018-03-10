using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Fornecedor
    {
        #region Atributos

        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public long CpfCnpj { get; set; }
        public int TipoPessoa { get; set; }
        public string NomeContato { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricacaoMunicipal { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<EnderecoFornecedor> EnderecoFornecedors { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual ICollection<TelefoneFornecedor> TelefoneFornecedors { get; set; }
        #endregion

        #region Construtores
        public Fornecedor()
        {
            this.EnderecoFornecedors = new List<EnderecoFornecedor>();
            this.ProdutoFornecedors = new List<ProdutoFornecedor>();
            this.TelefoneFornecedors = new List<TelefoneFornecedor>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
