using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class TelefoneEmpresa
    {
        #region Atributos
        public int IdTelefoneEmpresa { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
        public int TipoTelefone { get; set; }
        public int IdEmpresa { get; set; }
        public virtual Empresa Empresa { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
        
    }
}
