namespace TeleHelp.Domain.Entities
{
    using System;
    using System.Collections.Generic;
 
    public partial class Empresa
    {
        public Empresa()
        {
            EnderecoEmpresa = new HashSet<EnderecoEmpresa>();
            TelefoneEmpresa = new HashSet<TelefoneEmpresa>();
        }
        
        public int IdEmpresa { get; set; }
        
        public string RazaoSocial { get; set; }
        
        public string NomeFantasia { get; set; }

        public long CpfCnpj { get; set; }
        
        public string InscricaoEstadual { get; set; }
        
        public string InscricacaoMunicipal { get; set; }
        
        public string Observacao { get; set; }

        public bool Ativo { get; set; }
        
        public virtual ICollection<EnderecoEmpresa> EnderecoEmpresa { get; set; }
        
        public virtual ICollection<TelefoneEmpresa> TelefoneEmpresa { get; set; }
    }
}
