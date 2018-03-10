using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Application.Interface
{
    public interface IUsuarioAplication : IAplicationBase<Usuario>
    {
        IList<string> ValidaLogin(string login, string senha);
        bool AddUsuario(IUsuarioDTO usuarioDTO);
        IList<GrupoUsuario> GetListaGrupoUsuario(int idUsuario);
        RepresentanteUsuario GetRepresentanteUsuario(int idUsuario);
        bool RemoveALLUsuario(IUsuarioDTO usuarioDTO);
    }
}
