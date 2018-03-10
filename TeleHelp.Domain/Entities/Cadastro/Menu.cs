using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Menu
    {
        #region Atributos
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public string Caminho { get; set; }
        public bool Ativo { get; set; }
        public int IdSistema { get; set; }
        public virtual ICollection<Funcionalidade> Funcionalidades { get; set; }
        public virtual ICollection<ModuloMenu> ModuloMenus { get; set; }
        #endregion

        #region Construtores
        public Menu()
        {
            this.Funcionalidades = new List<Funcionalidade>();
            this.ModuloMenus = new List<ModuloMenu>();
        }
        #endregion

        #region Metodos
        #endregion
   
    }
}
