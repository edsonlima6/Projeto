using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Usuario
    {

        #region Atributos

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> Matricula { get; set; }
        public Nullable<int> Turno { get; set; }
        public Nullable<System.TimeSpan> HorarioEntrada { get; set; }
        public Nullable<System.TimeSpan> HorarioSaida { get; set; }
        public int TipoUsuario { get; set; }
        public int TipoPerfil { get; set; }
        public int TipoAtendimento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }
        public Nullable<int> IdLogin { get; set; }
        public virtual ICollection<AgendaUsuarioIndicacao> AgendaUsuarioIndicacao { get; set; }
        public virtual ICollection<Atendimento> Atendimento { get; set; }
        public virtual ICollection<Auditoria> Auditoria { get; set; }
        public virtual ICollection<Auditoria> Auditoria1 { get; set; }
        //public virtual ICollection<BonificacaoUnidadeCliente> BonificacaoUnidadeCliente { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual ICollection<ComissaoUsuario> ComissaoUsuario { get; set; }
        public virtual ICollection<ContatoCliente> ContatoCliente { get; set; }
        public virtual ICollection<ControleArquivo> ControleArquivo { get; set; }
        public virtual ICollection<ControleEmail> ControleEmail { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<EstoqueTransferencia> EstoqueTransferencia { get; set; }
        public virtual ICollection<EstoqueTransferencia> EstoqueTransferencia1 { get; set; }
        public virtual ICollection<FilaUsuarioIndicacao> FilaUsuarioIndicacao { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuario { get; set; }
        public virtual ICollection<HistoricoIndicacao> HistoricoIndicacao { get; set; }
        public virtual ICollection<HistoricoLoginUsuario> HistoricoLoginUsuario { get; set; }
        public virtual ICollection<HistoricoSAT> HistoricoSAT { get; set; }
        public virtual ICollection<Indicacao> Indicacao { get; set; }
        public virtual ICollection<Indicacao> Indicacao1 { get; set; }
        public virtual ICollection<Ligacao> Ligacao { get; set; }
        //public virtual Login Login { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProduto { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProduto1 { get; set; }
        public virtual ICollection<PedidoProduto> PedidoProduto2 { get; set; }
        public virtual ICollection<PedidoVenda> PedidoVenda { get; set; }
        public virtual ICollection<QuestionarioIndicacao> QuestionarioIndicacao { get; set; }
        public virtual ICollection<RamalUsuario> RamalUsuario { get; set; }
        public virtual ICollection<RepresentanteUsuario> RepresentanteUsuario { get; set; }
        public virtual ICollection<SAT> SAT { get; set; }
        public virtual ICollection<TituloCliente> TituloCliente { get; set; }
        public virtual ICollection<TituloCliente> TituloCliente1 { get; set; }
        public virtual ICollection<TituloCliente> TituloCliente2 { get; set; }
        #endregion

        #region Construtores

        public Usuario()
        {
            this.AgendaUsuarioIndicacao = new List<AgendaUsuarioIndicacao>();
            this.Atendimento  = new List<Atendimento>();
            this.Auditoria = new List<Auditoria>();
            this.Auditoria1 = new List<Auditoria>();
            //this.BonificacaoUnidadeCliente = new List<BonificacaoUnidadeCliente>();
            this.ComissaoUsuario = new List<ComissaoUsuario>();
            this.ContatoCliente = new List<ContatoCliente>();
            this.ControleArquivo = new List<ControleArquivo>();
            this.ControleEmail = new List<ControleEmail>();
            this.EstoqueTransferencia = new List<EstoqueTransferencia>();
            this.EstoqueTransferencia1 = new List<EstoqueTransferencia>();
            this.FilaUsuarioIndicacao = new List<FilaUsuarioIndicacao>();
            this.GrupoUsuario = new List<GrupoUsuario>();
            this.HistoricoIndicacao = new List<HistoricoIndicacao>();
            this.HistoricoLoginUsuario = new List<HistoricoLoginUsuario>();
            this.HistoricoSAT = new List<HistoricoSAT>();
            this.Indicacao = new List<Indicacao>();
            this.Indicacao1 = new List<Indicacao>();
            this.Ligacao = new List<Ligacao>();
            this.PedidoProduto = new List<PedidoProduto>();
            this.PedidoProduto1 = new List<PedidoProduto>();
            this.PedidoProduto2 = new List<PedidoProduto>();
            this.PedidoVenda = new List<PedidoVenda>();
            this.QuestionarioIndicacao = new List<QuestionarioIndicacao>();
            this.RamalUsuario = new List<RamalUsuario>();
            this.RepresentanteUsuario = new List<RepresentanteUsuario>();
            this.SAT = new List<SAT>();
            this.TituloCliente = new List<TituloCliente>();
            this.TituloCliente1 = new List<TituloCliente>();
            this.TituloCliente2 = new List<TituloCliente>();
        }

        #endregion

        #region Metodos
        #endregion

    }
}
