using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Services;

namespace TeleHelp.Application.Services
{
    public class UsuarioAplication : AplicationBase<Usuario>, IUsuarioAplication
    {
        private readonly IUsuarioService _usuarioservice;

        public UsuarioAplication(IUsuarioService _Usuarioservice) : base(_Usuarioservice)
        {
            _usuarioservice = _Usuarioservice;
        }


        public IList<string> ValidaLogin(string login, string senha)
        {
            try
            {
                return _usuarioservice.ValidaLogin(login, senha);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool AddUsuario(IUsuarioDTO usuarioDTO)
        {
            return _usuarioservice.AddUsuario(usuarioDTO);
        }

        public IList<GrupoUsuario> GetListaGrupoUsuario(int idUsuario)
        {
            return _usuarioservice.GetListaGrupoUsuario(idUsuario);
        }

        public RepresentanteUsuario GetRepresentanteUsuario(int idUsuario)
        {
            return _usuarioservice.GetRepresentanteUsuario(idUsuario);
        }

        public bool RemoveALLUsuario(IUsuarioDTO usuarioDTO)
        {
            return _usuarioservice.RemoveAllUsuario(usuarioDTO);
        }
    }
}
