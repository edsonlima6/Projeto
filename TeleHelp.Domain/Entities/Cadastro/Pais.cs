using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Pais
    {
        #region Atributos
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string DDI { get; set; }
        public virtual ICollection<Estado> Estadoes { get; set; }
        #endregion

        #region Construtores
        public Pais()
        {
            this.Estadoes = new List<Estado>();
        }
        #endregion

        #region Metodos
        #endregion
   
    }
}
