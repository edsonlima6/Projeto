using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class ComboServico
    {
        #region Atributos
        public int IdComboServico { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorDesconto { get; set; }
        public string Ativo { get; set; }
        public int IdCombo { get; set; }
        public int IdServico { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual Servico Servico { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
    
    }
}
