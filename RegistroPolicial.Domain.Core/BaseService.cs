using System;
using System.Collections.Generic;
using RegistroPolicial.Domain.Interfaces.Repositories;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Domain.Core
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> baseRepository;
        
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        
        public TEntity AddEntity(TEntity entity)
        {
            return this.baseRepository.AddEntity(entity);
        }

        public IEnumerable<TEntity> GetAllEntity()
        {
            return this.baseRepository.GetAllEntity();
        }

        public TEntity GetByIdEntity(int id)
        {
            return this.baseRepository.GetByIdEntity(id);
        }

        public void ModifyEntity(TEntity entity)
        {
            this.baseRepository.ModifyEntity(entity);
        }

        public void DeleteEntity(int id)
        {
            this.baseRepository.DeleteEntity(id);
        }

        public void Dispose()
        {
            this.baseRepository.Dispose();
        }
        
        
    }
}