using System;
using System.Collections.Generic;
using System.Text;
using Training.Testing.Domain;

namespace Training.Testing.Services
{
    public interface IService<Domain>
        where Domain : IDomain
    {
        Domain Add(Domain entity);

        Domain Update(Domain entity);

        Domain Get(int id);

        IEnumerable<Domain> Get();

        void Delete(int id);
    }
}
