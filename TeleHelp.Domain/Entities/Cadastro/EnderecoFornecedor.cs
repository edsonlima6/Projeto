using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class EnderecoFornecedor
    {
        #region Atributos
        public int IdEnderecoFornecedor { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
        public int TipoEndereco { get; set; }
        public bool Ativo { get; set; }
        public int IdFornecedor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion

    }
}
