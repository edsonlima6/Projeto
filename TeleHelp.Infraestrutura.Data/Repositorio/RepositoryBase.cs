using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Infraestrutura.Data.Contexto;

namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected MyBIContexto Db = new MyBIContexto();
        
        public void Add(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Add(obj);
            }
            catch (DbUpdateException erroDbUpdateException)
            {
                Delete(obj);
                throw erroDbUpdateException;
            }
            catch (Exception exAdd)
            {
                Delete(obj);
                throw exAdd;
            }
        }

        public void Delete(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(int? id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void SaveChanges()
        {
            try
            {
                Db.SaveChanges();
            }
            catch (DbUpdateException erroDbUpdateException)
            {
                throw erroDbUpdateException;
            }
            catch (Exception erroException)
            {
                throw erroException;
            }
        }
        

        public void Update(TEntity obj)
        {
            try
            {
                Db.Entry(obj).State = EntityState.Modified;
            }
            catch (DbUpdateException erroDbUpdateException)
            {
                throw erroDbUpdateException;
            }
            catch (Exception ex)
            {
                Delete(obj);
                throw ex;
            }
        }
        



    }
}
