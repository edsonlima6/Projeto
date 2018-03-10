using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Cargo
    {
        #region Atributos

        public int IdCargo
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }
        public string Descricao
        {
            get;
            set;
        }
        public bool Ativo
        {
            get;
            set;
        }
        public virtual ICollection<Usuario> Usuario
        {
            get;
            set;
        }

        #endregion

        #region Construtores
        public Cargo()
        {
            this.Usuario = new List<Usuario>();
        }

        #endregion

        #region Metodos

        #endregion

    }
}
