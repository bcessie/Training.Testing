using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Training.Testing.Domain;
using Training.Testing.Repo;

namespace Training.Testing.Services
{
    public class PhraseService : BaseService<Data.Phrase, Phrase>, IService<Phrase>
    {
        public PhraseService() : base()
        {
            Repo = new PhraseRepo();
        }

        public PhraseService(IMapper mapper) : base(mapper)
        {
            Repo = new PhraseRepo();
        }

        public Phrase Add(Phrase item)
        {
            if (item.IsValid())
            {
                var model = Mapper.Map<Data.Phrase>(item);
                var result = Repo.Add(model);
                return Mapper.Map<Phrase>(result);
            }

            return item;
        }

        public Phrase Get(int id)
        {
            var result = Repo.Get(id);
            return Mapper.Map<Phrase>(result);
        }

        public IEnumerable<Phrase> Get()
        {
            var result = Repo.Get();
            return Mapper.Map<IEnumerable<Phrase>>(result);
        }

        public Phrase Update(Phrase item)
        {
            if (item.IsValid())
            {
                var model = Mapper.Map<Data.Phrase>(item);
                var result = Repo.Update(model);
                return Mapper.Map<Phrase>(result);
            }

            return item;
        }

        public void Delete(int id)
        {
            Repo.Delete(id);
        }
    }
}
