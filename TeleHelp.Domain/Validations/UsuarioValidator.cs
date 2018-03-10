using FluentValidation;
using System;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Domain.Validations
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        
        public UsuarioValidator(bool value)
        {
            RuleFor(u => u.Login)
                .NotEmpty()
                .WithMessage("LOGIN DEVE SER INFORMADO");

            RuleFor(u => u.Senha)
               .NotEmpty()
               .WithMessage("SENHA DEVE SER INFORMADO");

            //SE A PROPRIEDADE VALUE FOR VERDADEIRA VALIDA OS DEMAIS CAMPOS
            if (value)
            {
                RuleFor(u => u.DataCadastro)
                    .NotEmpty()
                    .NotNull()
                    .LessThan(DateTime.Now);

                //RuleFor(u => u.Foto).Configure()

                RuleFor(u => u.Nome)
                   .NotEmpty()
                   .WithMessage("NOME DEVE SER INFORMADO");

                RuleFor(u => u.IdTipoAtendimento)
                   .NotEmpty()
                    .WithMessage("TIPO DE ATENDIMENTO DEVE SER INFORMADO");

                RuleFor(u => u.IdTipoUsuario)
                   .NotEmpty()
                   .WithMessage("TIPO DE USUÁRIO DEVE SER INFORMADO");

                RuleFor(u => u.IdCargo)
                   .NotEmpty()
                   .WithMessage("CARGO DEVE SER INFORMADO");

                RuleFor(u => u.IdDepartamento)
                   .NotEmpty()
                    .WithMessage("DEPARTAMENTO DEVE SER INFORMADO");
            }
        }
    }
}
