using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Reclamacao
    {

        #region Atributos
        public int IdReclamacao { get; set; }
        public string Nome { get; set; }
        public int TipoReclamacao { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public int IdDepartamento { get; set; }
        public virtual ICollection<SAT> SAT { get; set; }
        #endregion

        #region Construtores
        public Reclamacao()
        {
            this.SAT = new List<SAT>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
