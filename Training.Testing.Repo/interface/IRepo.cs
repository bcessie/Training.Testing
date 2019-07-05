using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Testing.Repo
{
    public interface IRepo<TEntity>
        where TEntity : class
    {
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Get(int id);

        IEnumerable<TEntity> Get();

        void Delete(int id);
    }
}
