using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Solicitacao
    {
        #region Atributos
        public int IdSolicitacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Atendimento> Atendimentoes { get; set; }
        #endregion

        #region Construtores
        public Solicitacao()
        {
            this.Atendimentoes = new List<Atendimento>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
