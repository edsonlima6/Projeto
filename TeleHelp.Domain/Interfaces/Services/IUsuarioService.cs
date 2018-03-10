using System.Collections.Generic;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {

        IList<string> ValidaLogin(string login, string senha);
        bool AddUsuario(IUsuarioDTO usuarioDTO);
        IList<GrupoUsuario> GetListaGrupoUsuario(int idUsuario);
        RepresentanteUsuario GetRepresentanteUsuario(int idUsuario);
        bool RemoveAllUsuario(IUsuarioDTO usuarioDTO);
    }
}
