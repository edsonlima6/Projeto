using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Evento
    {
        #region Atributos
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<EventoCliente> EventoClientes { get; set; }
        #endregion

        #region Construtores
        public Evento()
        {
            this.EventoClientes = new List<EventoCliente>();
        }
        #endregion

        #region Metodos
        #endregion
 
    }
}
