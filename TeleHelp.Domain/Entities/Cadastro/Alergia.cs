using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Alergia
    {
        #region Atributos

        public int IdAlergia { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TpAlergia TipoAlergia { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<AlergiaCliente> AlergiaClientes { get; set; }
        public enum TpAlergia : int
        {
            INDETERMINADO = 0,
            ALIMENTAR = 1,
            ANIMAIS = 2,
            DERMATOLOGICA = 3,
            INSETOS = 4,
            MEDICAMENTOS = 5,
            RESPIRATORIA = 6
        }

        #endregion

        #region Construtores
        public Alergia()
        {
            this.AlergiaClientes = new List<AlergiaCliente>();
        }

        #endregion

        #region Metodos
        #endregion
    }
}
