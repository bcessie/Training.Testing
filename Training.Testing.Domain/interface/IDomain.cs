using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Testing.Domain
{
    public interface IDomain
    {
        int Id { get; set; }

        bool IsValid();
    }
}
