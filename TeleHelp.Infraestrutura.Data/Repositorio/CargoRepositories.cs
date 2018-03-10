using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Infraestrutura.Data.Repositorio;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class CargoRepositories : RepositoryBase<Cargo>, ICargoRepository
    {

        public CargoRepositories()
        {

        }

    }
}
