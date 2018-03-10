using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Questionario
    {
        #region Atributos
        public int IdQuestionario { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<QuestionarioPergunta> QuestionarioPergunta { get; set; }
        public virtual ICollection<QuestionarioIndicacao> QuestionarioIndicacao { get; set; }
        #endregion

        #region Construtores
        public Questionario()
        {
            this.QuestionarioPergunta = new List<QuestionarioPergunta>();
            this.QuestionarioIndicacao = new List<QuestionarioIndicacao>();
        }
        #endregion

        #region Metodos
        #endregion
 
    }
}
