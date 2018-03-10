using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class GrupoUsuarioRepository : RepositoryBase<GrupoUsuario>, IGrupoUsuarioRepository
    {

        public GrupoUsuarioRepository()
        {

        }

        public IList<GrupoUsuario> GetGrupoUsuario(int usuarioID)
        {
            try
            {
                return new List<GrupoUsuario>();// Db.GrupoUsuarios.Where(gu => gu.IdUsuario == usuarioID).ToList();
            }
            catch (Exception erroGetGrupoUsuario)
            {
                throw erroGetGrupoUsuario;
            }
        }
    }
}
