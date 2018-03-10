using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Resposta
    {
        #region Atributos
        public int IdResposta { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<RepostaPergunta> RepostaPerguntas { get; set; }
        #endregion

        #region Construtores
        public Resposta()
        {
            this.RepostaPerguntas = new List<RepostaPergunta>();
        }
        #endregion

        #region Metodos
        #endregion
 
    }
}
