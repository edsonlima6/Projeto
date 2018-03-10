using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class TelaRepository : RepositoryBase<Tela>, ITelaRepository
    {
        
        public TelaRepository()
        {

        }

    }
}
