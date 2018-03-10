using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class RamalUsuario
    {
        #region Atributos
        public int IdRamalUsuario { get; set; }
        public int Ramal { get; set; }
        public Nullable<int> DDD { get; set; }
        public Nullable<int> Telefone { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
  
    }
}
