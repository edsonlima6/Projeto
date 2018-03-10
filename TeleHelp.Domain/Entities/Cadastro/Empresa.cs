using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities.Cadastro
{
    public class Empresa
    {
        #region Atributos
        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public long CpfCnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricacaoMunicipal { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<EnderecoEmpresa> EnderecoEmpresas { get; set; }
        public virtual ICollection<TelefoneEmpresa> TelefoneEmpresas { get; set; }
        #endregion

        #region Construtores
        public Empresa()
        {
            this.EnderecoEmpresas = new List<EnderecoEmpresa>();
            this.TelefoneEmpresas = new List<TelefoneEmpresa>();
        }
        #endregion

        #region Metodos
        
        #endregion
  
    }
}
