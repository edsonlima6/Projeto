﻿using MyBI_Identity.Models.AreaCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBI_Identity.Models
{
    public class EmpresaViewModels
    {
        public EmpresaViewModels()
        {

        }


        public int idRazaoSocial { get; set; }

        [Display(Name = "Tipo de Empresa")]
        [Required(ErrorMessage = "Tipo de Empresa é obrigatório")]
        public int idTipoEmpresa { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Estado é obrigatório")]
        public int idEstado { get; set; }

        [Display(Name ="Razão Social")]
        [Required(ErrorMessage ="Nome da Empresa é obrigatório")]
        public string sRazaoSocial { get; set; }

        public DateTime dtCadastro { get; set; }

        [Display(Name = "Dia da Cobrança")]
        public int nDiaCobranca { get; set; }

        [Display(Name = "CNPJ/CPF")]
        [MaxLength(14, ErrorMessage ="CPF/CNPJ Inválido")]
        public string sCnpjCpf { get; set; }

        [Display(Name = "Endereço")]
        public string sEndereco { get; set; }

        [Display(Name = "Cidade")]
        public string sCidade { get; set; }

 
        public string sEstado { get; set; }

        [Display(Name = "Telefone Contato")]
        [MaxLength(12, ErrorMessage = "Telefone Inválido")]
        public string nContato { get; set; }

        [Display(Name = "CEP")]
        public string sCep { get; set; }

        [Display(Name = "Corrente")]
        public bool sCorrente { get; set; }

        [Display(Name = "Qtde de Parcelas")]
        public int nQtdeParcelas { get; set; }

        [Display(Name = "Valor Aproximado")]
        public decimal nValorAproximado { get; set; }
        

        public List<TipoEmpresaViewModels> tpEmpresasVM { get; set; }

        public List<EstadoViewModel> EstadoVM { get; set; }
    }
}