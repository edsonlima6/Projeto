using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Cidade
    {
        #region Atributos
        public int IdCidade { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string DDD { get; set; }
        public bool RT { get; set; }
        public int IdEstado { get; set; }
        public virtual ICollection<Cep> Ceps { get; set; }
        public virtual Estado Estado { get; set; }
        #endregion

        #region Construtores
        public Cidade()
        {
            this.Ceps = new List<Cep>();
        }
        #endregion

        #region Metodos
        #endregion
   
    }
}
