using System;
using System.Collections.Generic;
using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Application.Main.Services
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> baseService;
        
        public BaseAppService(IBaseService<TEntity> baseService)
        {
            this.baseService = baseService;
        }

        public IEnumerable<TEntity> GetAllEntity()
        {
            return this.baseService.GetAllEntity();
        }

        public TEntity AddEntity(TEntity entity)
        {
            return this.baseService.AddEntity(entity);
        }

        public TEntity GetByIdEntity(int id)
        {
            return this.baseService.GetByIdEntity(id);
        }

        public void DeleteEntity(int id)
        {
            this.baseService.DeleteEntity(id);
        }

        public void ModifyEntity(TEntity entity)
        {
            this.baseService.ModifyEntity(entity);
        }

        public void Dispose()
        {
            this.baseService.Dispose();
        }
    }
}