using System.Collections.Generic;

namespace WebApplication1.Repository.Base
{
    public interface IRepositoryAdo<TEntity>
    {
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
        IEnumerable<TEntity> All();

        TEntity Get(int id);
    }
}