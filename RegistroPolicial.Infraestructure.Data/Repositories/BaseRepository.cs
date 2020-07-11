using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using RegistroPolicial.Domain.Interfaces.Repositories;

namespace RegistroPolicial.Infraestructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {        
        public TEntity AddEntity(TEntity entity)
        {
            TEntity created = null;
            try
            {
                using (var context = new RegistroPolicialEntities())
                {
                    created = context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }

            return created;
        }

        public IEnumerable<TEntity> GetAllEntity()
        {
            try
            {
                using (var context = new RegistroPolicialEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }

        public TEntity GetByIdEntity(int id)
        {
            try
            {
                using (var context = new RegistroPolicialEntities())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo recuperar el registro", ex);
            }
        }

        public void DeleteEntity(int id)
        {            
            try
            {
                using (var context = new RegistroPolicialEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el registro", ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }      

        public void ModifyEntity(TEntity entity)
        {
            try
            {
                using (var context = new RegistroPolicialEntities())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }
        }
    }
}