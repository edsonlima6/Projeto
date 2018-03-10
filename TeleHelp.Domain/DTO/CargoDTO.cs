namespace TeleHelp.Domain.DTO
{
    using System;
    using System.Collections.Generic;
    using TeleHelp.Domain.DTO.InterfacesDTO;
    using TeleHelp.Domain.Entities;
    using TeleHelp.Domain.Validations;

    public class CargoDTo : ICargoDTO
    {
        Cargo _cargo;
        public CargoDTo()
        {
            listaCargos = new List<Cargo>();
        }

        public int IdCargo { get; set; }

    
        public string Nome { get; set; }

       
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        public List<Cargo> listaCargos { get; set; }

        public Cargo GetCargo()
        {
            string erros = string.Empty;
            try
            {

                _cargo = new Cargo() { Nome = this.Nome, Descricao = this.Descricao, Ativo = this.Ativo, IdCargo = this.IdCargo };
                var _validatorCargo = new CargoValidator().Validate(_cargo);
                if (!_validatorCargo.IsValid)
                {
                    foreach (var item in _validatorCargo.Errors)
                    {
                        erros += item.ErrorMessage + "\n";
                    }
                    throw new Exception(erros);
                }
                
                return _cargo;
            }
            catch (Exception error)
            {
                throw error;
            }


        }


    }
}
