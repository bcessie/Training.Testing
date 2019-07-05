using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Testing.Domain
{
    public class BaseDomain
    {
        public int Id { get; set; }

        public IList<string> ErrorMessges { get; set; } = new List<string>();
    }
}
