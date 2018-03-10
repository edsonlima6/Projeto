using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Agenda
    {
        #region Atributos
        public int IdAgenda { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoAgenda { get; set; }
        public int Periodo { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Acao> Acaos { get; set; }

        #endregion

        #region Construtores
        public Agenda()
        {
            this.Acaos = new List<Acao>();
        }
        #endregion

        #region Metodos
        #endregion
    }
}
