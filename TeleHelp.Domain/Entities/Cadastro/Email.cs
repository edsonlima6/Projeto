using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Email
    {
        #region Atributos

        public int IdEmail { get; set; }
        public string Nome { get; set; }
        public string Servidor { get; set; }
        public string Email1 { get; set; }
        public string Senha { get; set; }
        public string SSL { get; set; }
        public Nullable<int> Porta { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public int TipoEmail { get; set; }
        public string Arquivo { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<ControleEmail> ControleEmail { get; set; }
        #endregion

        #region Construtores
        public Email()
        {
            this.ControleEmail = new List<ControleEmail>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
