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
        readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        readonly IRepresentanteUsuarioRepository _representanteUsuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IGrupoUsuarioRepository grupoUsuarioRepository, IRepresentanteUsuarioRepository representanteUsuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _grupoUsuarioRepository = grupoUsuarioRepository;
            _representanteUsuarioRepository = representanteUsuarioRepository;

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
            var representaUsuario = _representanteUsuarioRepository.GetRepresentanteUsuario(usuarioDTO.Usuario.IdUsuario).FirstOrDefault();
            if (representaUsuario != null)
            {
                _representanteUsuarioRepository.Delete(representaUsuario);
                _representanteUsuarioRepository.SaveChanges();
            }
            
            var gruposUsuario = _grupoUsuarioRepository.GetGrupoUsuario(usuarioDTO.Usuario.IdUsuario);
            foreach (var grupo in gruposUsuario)
            {
                _grupoUsuarioRepository.Delete(grupo);
                _grupoUsuarioRepository.SaveChanges();
            }

            var usuario = _usuarioRepository.GetById(usuarioDTO.Usuario.IdUsuario);
            if (usuario != null)
            {
                _usuarioRepository.Delete(usuario);
                _usuarioRepository.SaveChanges();
            }
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

            _usuarioRepository.Add(usuarioDTO.Usuario);
            _usuarioRepository.SaveChanges();

            //Grava os grupos que o usuário terá acesso
            if (usuarioDTO.gruposUsuario != null && usuarioDTO.gruposUsuario.Count > 0)
            {
                foreach (var grupo in usuarioDTO.gruposUsuario)
                {
                    grupo.IdUsuario = usuarioDTO.Usuario.IdUsuario;
                    _grupoUsuarioRepository.Add(grupo);
                }
                _grupoUsuarioRepository.SaveChanges();
            }
            //GRAVA O REPRESENTANTE, CASO O USUÁRIO SEJA VENDEDOR
            if (usuarioDTO.representanteUsuario != null && usuarioDTO.representanteUsuario.IdRepresentante > 0)
            {
                usuarioDTO.representanteUsuario.IdUsuario = usuarioDTO.Usuario.IdUsuario;
                _representanteUsuarioRepository.Add(usuarioDTO.representanteUsuario);
                _representanteUsuarioRepository.SaveChanges();
            }
        }


        private void AtualizaRepresentante(IUsuarioDTO usuarioDTO)
        {
            var validaRepresentante = _representanteUsuarioRepository.GetRepresentanteUsuario(usuarioDTO.Usuario.IdUsuario)
                                                                .FirstOrDefault(r => r.IdUsuario == usuarioDTO.Usuario.IdUsuario);

            if (usuarioDTO.representanteUsuario !=null && usuarioDTO.representanteUsuario.IdRepresentante > 0)
            {

                if (validaRepresentante != null)
                {
                    validaRepresentante.IdRepresentante = usuarioDTO.representanteUsuario.IdRepresentante;
                    validaRepresentante.Ativo = usuarioDTO.representanteUsuario.Ativo;
                    _representanteUsuarioRepository.Update(validaRepresentante);
                    _representanteUsuarioRepository.SaveChanges();

                }
                else if (validaRepresentante == null && usuarioDTO.representanteUsuario.IdRepresentante > 0)
                {
                    usuarioDTO.representanteUsuario.IdUsuario = usuarioDTO.Usuario.IdUsuario;
                    _representanteUsuarioRepository.Add(usuarioDTO.representanteUsuario);
                    _representanteUsuarioRepository.SaveChanges();
                }

                //FAZER O DELETE DO REPRESENTANTE
            }
            if (usuarioDTO.IdTipoUsuario == SistemaEnuns.TipoUsuario.USUARIO.GetHashCode() && validaRepresentante != null)
            {
                _representanteUsuarioRepository.Delete(validaRepresentante);
                _representanteUsuarioRepository.SaveChanges();
            }
        }

        private void AtualizaGrupo(IUsuarioDTO usuarioDTO)
        {
            //ATUALIZA OS GRUPOS DO USUÁRIO
            if (usuarioDTO.gruposUsuario != null && usuarioDTO.gruposUsuario.Count >= 0)
            {
                var grupoBD = _grupoUsuarioRepository.GetGrupoUsuario(usuarioDTO.Usuario.IdUsuario);
                foreach (var grupo in usuarioDTO.gruposUsuario)
                {
                    var validaGrupo = grupoBD.FirstOrDefault(g => g.IdGrupo == grupo.IdGrupo);
                    if (validaGrupo != null)
                    {
                        validaGrupo.DataFim = grupo.DataFim;
                        validaGrupo.DataInicio = grupo.DataInicio;
                        _grupoUsuarioRepository.Update(validaGrupo);
                        _grupoUsuarioRepository.SaveChanges();
                        grupoBD.Remove(validaGrupo);
                    }
                    else
                    {
                        _grupoUsuarioRepository.Add(grupo);
                        _grupoUsuarioRepository.SaveChanges();
                        grupoBD.Remove(validaGrupo);
                    }
                }
                if (grupoBD.Count > 0)
                {
                    foreach (var gruposExclusos in grupoBD)
                    {
                        _grupoUsuarioRepository.Delete(gruposExclusos);
                        _grupoUsuarioRepository.SaveChanges();
                    }
                }
            }
        }

        public IList<GrupoUsuario> GetListaGrupoUsuario(int idUsuario)
        {
            return _grupoUsuarioRepository.GetGrupoUsuario(idUsuario);
        }

        public RepresentanteUsuario GetRepresentanteUsuario(int idUsuario)
        {
            return _representanteUsuarioRepository.GetRepresentanteUsuario(idUsuario).FirstOrDefault();
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
