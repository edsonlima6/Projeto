using System;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Validations;

namespace TeleHelp.Domain.DTO
{
    public class GrupoDTO
    {
        Grupo _grupo;
        public GrupoDTO(string nome, string descricao, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
        }
        public GrupoDTO()
        {

        }

        public int IdGrupo { get; set; }


        public string Nome { get; set; }


        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public Grupo GetGrupo()
        {
            string erros = string.Empty;
            try
            {

                _grupo = new Grupo() { Nome = this.Nome, Descricao = this.Descricao, Ativo = this.Ativo, IdGrupo = this.IdGrupo };
                var _validatorCargo = new GrupoValidator().Validate(_grupo);
                if (!_validatorCargo.IsValid)
                {
                    foreach (var item in _validatorCargo.Errors)
                    {
                        erros += item.ErrorMessage + " \n";
                    }
                    throw new Exception(erros);
                }

                return _grupo;
            }
            catch (Exception error)
            {
                throw error;
            }


        }


    }
}
