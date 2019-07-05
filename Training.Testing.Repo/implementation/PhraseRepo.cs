using System;
using System.Collections.Generic;
using System.Text;
using Training.Testing.Data;

namespace Training.Testing.Repo
{
    public class PhraseRepo : BaseRepo, IRepo<Phrase>
    {
        public PhraseRepo() : base()
        {

        }

        public PhraseRepo(PhraseContext context) : base(context)
        {

        }


        public virtual Phrase Add(Phrase entity)
        {
            Context.Phrases.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public virtual Phrase Get(int id)
        {
            return Context.Phrases.Find(id);
        }

        public virtual IEnumerable<Phrase> Get()
        {
            return Context.Phrases;
        }

        public virtual Phrase Update(Phrase entity)
        {
            Context.Phrases.Update(entity);
            Context.SaveChanges();
            return entity;
        }

        public virtual void Delete(int id)
        {
            var phrase = Get(id);
            Context.Phrases.Remove(phrase);
            Context.SaveChanges();
        }
    }
}
