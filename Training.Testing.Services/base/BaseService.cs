using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Training.Testing.Domain;
using Training.Testing.Repo;

namespace Training.Testing.Services
{
    public class BaseService<TEntity, Domain>
        where TEntity : class
        where Domain : IDomain
    {
        public IRepo<TEntity> Repo { get; set; }
        public IMapper Mapper { get; set; }

        public BaseService()
        {

        }

        public BaseService(IMapper mapper)
        {
            Mapper = mapper;
        }

        public BaseService(IRepo<TEntity> repo, IMapper mapper) : this(mapper)
        {
            Repo = repo;
        }
    }
}
