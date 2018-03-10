using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class GrupoTelaRepository : RepositoryBase<PermissaoTela>, IGrupoTelaRepository
    {
        public IList<PermissaoTela> GetTelasHabilitadas(int IdGrupo)
        {
            return new List<PermissaoTela>();//Db.PermissaoTelas.Where(pt => pt.IdGrupo.Equals(IdGrupo)).ToList();
        }
    }
}
