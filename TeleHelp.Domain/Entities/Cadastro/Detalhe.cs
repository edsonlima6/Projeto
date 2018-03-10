using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Detalhe
    {
        #region Atributos
        #endregion

        #region Construtores
        public Detalhe()
        {
            this.DetalheClientes = new List<DetalheCliente>();
            this.DetalheIndicacao = new List<DetalheIndicacao>();
            this.DetalheServicoes = new List<DetalheServico>();
        }
        #endregion

        #region Metodos
        public int IdDetalhe { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoDetalhe { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<DetalheCliente> DetalheClientes { get; set; }
        public virtual ICollection<DetalheIndicacao> DetalheIndicacao { get; set; }
        public virtual ICollection<DetalheServico> DetalheServicoes { get; set; }
        #endregion

    }
}
