using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBI_Identity.Models
{
    public class EmpresaViewModels
    {
        public int idRazaoSocial { get; set; }

        [Display(Name ="Razão Social")]
        public string sRazaoSocial { get; set; }

        public DateTime dtCadastro { get; set; }

        [Display(Name = "Dia da Cobrança")]
        public int nDiaCobranca { get; set; }

        [Display(Name = "CNPJ/CPF")]
        public string sCnpjCpf { get; set; }

        [Display(Name = "Endereço")]
        public string sEndereco { get; set; }

        [Display(Name = "Cidade")]
        public string sCidade { get; set; }

        [Display(Name = "Estado")]
        public string sEstado { get; set; }

        [Display(Name = "Telefone Contato")]
        public string nContato { get; set; }

        [Display(Name = "CEP")]
        public string sCep { get; set; }
        

        public bool sCorrente { get; set; }

        [Display(Name = "Qtde de Parcelas")]
        public int nQtdeParcelas { get; set; }

        [Display(Name = "Valor Aproximado")]
        public decimal nValorAproximado { get; set; }


        public TipoEmpresaViewModels tpEmpresa { get; set; }
    }
}