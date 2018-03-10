using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Relatorio
    {

        #region Atributos
        public int IdRelatorio { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoFormato { get; set; }
        public int IdFuncionalidadePermissao { get; set; }
        public int IdModuloMenuItem { get; set; }
        public virtual ICollection<ConsultaRelatorio> ConsultaRelatorios { get; set; }
        #endregion

        #region Construtores
        public Relatorio()
        {
            this.ConsultaRelatorios = new List<ConsultaRelatorio>();
        }
        #endregion

        #region Metodos
        #endregion

    }
}
