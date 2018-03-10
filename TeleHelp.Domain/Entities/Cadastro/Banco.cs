using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Banco
    {
        #region Atributos
        public int IdBanco { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public virtual ICollection<ContaCliente> ContaClientes { get; set; }
        public virtual ICollection<EnderecoBanco> EnderecoBancoes { get; set; }
        public virtual ICollection<InconsistenciaBanco> InconsistenciaBancoes { get; set; }
        public virtual ICollection<OperacaoBanco> OperacaoBanco { get; set; }

        #endregion

        #region Construtores
        public Banco()
        {
            this.ContaClientes = new List<ContaCliente>();
            this.EnderecoBancoes = new List<EnderecoBanco>();
            this.InconsistenciaBancoes = new List<InconsistenciaBanco>();
            this.OperacaoBanco = new List<OperacaoBanco>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
