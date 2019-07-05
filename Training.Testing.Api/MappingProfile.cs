using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Testing.Domain;

namespace Training.Testing.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Phrase, Data.Phrase>()
                .ReverseMap();
        }
    }
}
