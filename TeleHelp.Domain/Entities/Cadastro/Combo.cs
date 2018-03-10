using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Combo
    {
        #region Atributos
        public int IdCombo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<ComboServico> ComboServicoes { get; set; }
        #endregion

        #region Construtores
        public Combo()
        {
            this.ComboServicoes = new List<ComboServico>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
