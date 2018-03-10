using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class AssistenciaMedicaHospital
    {
        #region Atributos

        public int IdAssistenciaMedicaHospital { get; set; }
        public int IdHospital { get; set; }
        public int IdAssistenciaMedica { get; set; }
        public virtual AssistenciaMedica AssistenciaMedica { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<PlanoSaudeCliente> PlanoSaudeClientes { get; set; }
        #endregion

        #region Construtores
        public AssistenciaMedicaHospital()
        {
            this.PlanoSaudeClientes = new List<PlanoSaudeCliente>();
        }
        #endregion

        #region Metodos
        #endregion
    }
}
