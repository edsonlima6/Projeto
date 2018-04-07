using System;
using System.Collections.Generic;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Domain.Interfaces.Services;
using System.Transactions;
using System.Linq;
using TeleHelp.Domain.Enums.Comuns;

namespace TeleHelp.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        IList<string> erros = new List<string>();
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IList<string> ValidaLogin(string login, string senha)
        {

            try
            {
                //erros.Clear();
                //var user = new Usuario() { Login = login, Senha = senha };
                //var userValidator = new UsuarioValidator().Validate(user);
                //if (!userValidator.IsValid)
                //{
                //    foreach (var item in userValidator.Errors)
                //    {
                //        erros.Add(item.ErrorMessage.ToString() + "\n");
                //    }
                //    return erros;
                //}
                //if (!_usuarioRepository.ValidaLogin(user.Login, user.Senha))
                //{
                //    erros.Clear();
                //    erros.Add("Login/Senha Inválido");
                //}
                return erros;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool AddUsuario(IUsuarioDTO usuarioDTO)
        {
            try
            {
                if (usuarioDTO != null)
                {
                    using (var tran = new TransactionScope())
                    {
                        if (usuarioDTO.acao == Enums.Comuns.SistemaEnuns.Acao.INCLUIR)
                        {
                            AdicionaUsuario(usuarioDTO);
                        }
                        else if (usuarioDTO.acao == Enums.Comuns.SistemaEnuns.Acao.ALTERAR)
                        {
                            AtualizaUsuario(usuarioDTO);
                        }
                        else
                        {
                            RemoveUsuario(usuarioDTO);
                        }
                        tran.Complete();
                    }
                    return true;
                }
            }
            catch (Exception erroAdd)
            {
                throw erroAdd;
            }

            return false;
        }

        private void RemoveUsuario(IUsuarioDTO usuarioDTO)
        {
         
        }

        private void AtualizaUsuario(IUsuarioDTO usuarioDTO)
        {
            //ATUALIZA O USUARIO NO BANCO
            _usuarioRepository.UpdateUsuario(usuarioDTO.Usuario);

            AtualizaGrupo(usuarioDTO);
            AtualizaRepresentante(usuarioDTO);

        }

        private void AdicionaUsuario(IUsuarioDTO usuarioDTO)
        {
        }


        private void AtualizaRepresentante(IUsuarioDTO usuarioDTO)
        {
            
        }

        private void AtualizaGrupo(IUsuarioDTO usuarioDTO)
        {
           
        }

        public bool RemoveAllUsuario(IUsuarioDTO usuarioDTO)
        {
            try
            {
                using (var tran = new TransactionScope())
                {
                    RemoveUsuario(usuarioDTO);
                    tran.Complete();
                    return true;

                   
                }
               
            }
            catch (Exception erroExcluirBD)
            {
                throw erroExcluirBD;
            }
        }
    }
}
