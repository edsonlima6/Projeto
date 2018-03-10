using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Categoria
    {
        #region Atributos
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        #endregion

        #region Construtores
        public Categoria()
        {
            this.Produtoes = new List<Produto>();
        }
        #endregion

        #region Metodos
        #endregion
  
    }
}
