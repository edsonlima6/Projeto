using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class GrupoRepository : RepositoryBase<Grupo>, IGrupoRepository
    {
        public GrupoRepository()
        {

        }

        public void UpdateGrupo(Grupo _grupo)
        {
            //var grupoOld = Db.Grupos.Find(_grupo.IdGrupo);
            //if (grupoOld != null)
            //{
            //    grupoOld.Nome = _grupo.Nome;
            //    grupoOld.Descricao = _grupo.Descricao;
            //    grupoOld.Ativo = _grupo.Ativo;

            //    Db.Entry(grupoOld).State = EntityState.Modified;
            //    Db.SaveChanges();
            //}
        }

    }
}
