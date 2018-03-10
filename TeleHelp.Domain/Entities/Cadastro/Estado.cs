using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Estado
    {
        #region Atributos
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int IdPais { get; set; }
        public virtual ICollection<AliquotaICMS> AliquotaICMS { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual Pais Pais { get; set; }
        #endregion

        #region Construtores
        public Estado()
        {
            this.AliquotaICMS = new List<AliquotaICMS>();
            this.Cidades = new List<Cidade>();
        }
        #endregion

        #region Metodos
        #endregion
   
    }
}
