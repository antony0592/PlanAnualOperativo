using System.Collections.Generic;

namespace RegistroPolicial.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);
        IEnumerable<TEntity> GetAllEntity();
        TEntity GetByIdEntity(int identity);

        void DeleteEntity(int identity);
        void ModifyEntity(TEntity entity);
        void Dispose();
    }
}