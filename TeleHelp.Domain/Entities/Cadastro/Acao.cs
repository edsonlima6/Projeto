using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Acao
    {
        #region Atributos
        public int IdAcao { get; private set; }
        public string NomeAcao { get; set; }
        public int TipoAcao { get; set; }
        public bool Produtiva { get; set; }
        public Nullable<int> IdAgenda { get; set; }
        public virtual Agenda Agenda { get; set; }
        public virtual ICollection<HistoricoIndicacao> HistoricoIndicacao { get; set; }

        #endregion

        #region Construtores
        public Acao()
        {
            this.HistoricoIndicacao = new List<HistoricoIndicacao>();
        }
        #endregion

        #region Metodos
        #endregion
    }
}
