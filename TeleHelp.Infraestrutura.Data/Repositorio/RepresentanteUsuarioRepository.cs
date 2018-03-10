using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class RepresentanteUsuarioRepository : RepositoryBase<RepresentanteUsuario>, IRepresentanteUsuarioRepository
    {
        public RepresentanteUsuarioRepository()
        {

        }

        public IList<RepresentanteUsuario> GetRepresentanteUsuario(int usuarioID)
        {
            try
            {
                return new List<RepresentanteUsuario>();// Db.RepresentantesUsuarios.Where(r => r.IdUsuario == usuarioID).ToList();
            }
            catch (Exception erroLista)
            {
                throw erroLista;
            }
        }
    }
}
