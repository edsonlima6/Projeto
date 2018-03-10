using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class QuestionarioPergunta
    {
        #region Atributos
        public int IdQuestionarioPergunta { get; set; }
        public int IdQuestionario { get; set; }
        public int IdPergunta { get; set; }
        public virtual Pergunta Pergunta { get; set; }
        public virtual Questionario Questionario { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
  
    }
}
