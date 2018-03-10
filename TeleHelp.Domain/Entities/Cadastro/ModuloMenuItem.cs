using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class ModuloMenuItem
    {
        #region Atributos
        public int IdModuloMenuItem { get; private set; }
        public string Nome { get; set; }
        public int NumeroOrdem { get; set; }
        public byte[] Imagem { get; set; }
        public string Caminho { get; set; }
        public int IdModuloMenu { get; set; }
        public virtual ModuloMenu ModuloMenu { get; set; }
        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion
 
    }
}
