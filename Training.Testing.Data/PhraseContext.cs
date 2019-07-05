using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Testing.Data
{
    public class PhraseContext : DbContext
    {
        public virtual DbSet<Phrase> Phrases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=PhraseDB;Trusted_Connection=True;");
        }
    }
}
