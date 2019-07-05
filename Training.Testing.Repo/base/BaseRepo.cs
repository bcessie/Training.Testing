using System;
using System.Collections.Generic;
using System.Text;
using Training.Testing.Data;

namespace Training.Testing.Repo
{
    public class BaseRepo
    {
        public PhraseContext Context { get; set; }

        public BaseRepo(PhraseContext context)
        {
            Context = context;
        }

        public BaseRepo()
        {
            Context = new PhraseContext();
        }
    }
}
