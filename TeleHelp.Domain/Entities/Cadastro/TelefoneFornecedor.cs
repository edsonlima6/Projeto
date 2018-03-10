using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class TelefoneFornecedor
    {
        #region Atributos
        public int IdTelefoneFornecedor { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
        public int TipoTelefone { get; set; }
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
