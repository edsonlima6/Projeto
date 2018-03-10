using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class ModuloMenu
    {
        #region Atributos
        public int IdModuloMenu { get; set; }
        public string Nome { get; set; }
        public int NumeroOrdem { get; set; }
        public byte[] Imagem { get; set; }
        public string Caminho { get; set; }
        public int IdMenu { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<ModuloMenuItem> ModuloMenuItems { get; set; }
        #endregion

        #region Construtores
        public ModuloMenu()
        {
            this.ModuloMenuItems = new List<ModuloMenuItem>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
