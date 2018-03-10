using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class QuestionarioIndicacao
    {
        #region Atributos
        public int IdQuestionarioIndicacao { get; set; }
        public System.DateTime DataQuestionario { get; set; }
        public int IdIndicacao { get; set; }
        public int IdUsuario { get; set; }
        public int IdQuestionario { get; set; }
        public virtual Indicacao Indicacao { get; set; }
        public virtual Questionario Questionario { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion

    }
}
