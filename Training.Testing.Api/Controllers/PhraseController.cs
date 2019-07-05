using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Training.Testing.Domain;
using Training.Testing.Services;

namespace Training.Testing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhraseController : BaseController<Phrase>
    {
        public PhraseController(IMapper mapper)
        {
            Mapper = mapper;
            Service = new PhraseService(mapper);
        }
    }
}
