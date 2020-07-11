using System.Collections.Generic;

namespace RegistroPolicial.Application.Main.Interfaces
{
    public interface IBaseAppService<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);
        IEnumerable<TEntity> GetAllEntity();
        TEntity GetByIdEntity(int id);

        void DeleteEntity(int id);
        void ModifyEntity(TEntity entity);
        void Dispose();
    }
}