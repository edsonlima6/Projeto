using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class AssistenciaMedica
    {
        #region Atributos
        public int IdAssistenciaMedica { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<AssistenciaMedicaHospital> AssistenciaMedicaHospitals { get; set; }
        #endregion

        #region Construtores
        public AssistenciaMedica()
        {
            this.AssistenciaMedicaHospitals = new List<AssistenciaMedicaHospital>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
