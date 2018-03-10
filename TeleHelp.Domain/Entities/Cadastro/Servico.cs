using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Servico
    {
        #region Atributos
        public int IdServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorMensal { get; set; }
        public decimal ValorAnual { get; set; }
        public TpServico TipoServico { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Atendimento> Atendimentoes { get; set; }
        public virtual ICollection<BloqueioServico> BloqueioServicoes { get; set; }
        public virtual ICollection<ComboServico> ComboServicoes { get; set; }
        public virtual ICollection<DetalheServico> DetalheServicoes { get; set; }
        public virtual ICollection<ServicoProduto> ServicoProdutoes { get; set; }
        public virtual ICollection<ServicoUnidadeCliente> ServicoUnidadeCliente { get; set; }
        public enum TpServico : int
        {
            SERVICO=0,
            TAXA=1
        }
        #endregion

        #region Construtores
        public Servico()
        {
            this.Atendimentoes = new List<Atendimento>();
            this.BloqueioServicoes = new List<BloqueioServico>();
            this.ComboServicoes = new List<ComboServico>();
            this.DetalheServicoes = new List<DetalheServico>();
            this.ServicoProdutoes = new List<ServicoProduto>();
            this.ServicoUnidadeCliente = new List<ServicoUnidadeCliente>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
