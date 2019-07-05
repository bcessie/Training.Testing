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
    public class BaseController<Domain> : ControllerBase
        where Domain : IDomain
    {
        public IMapper Mapper { get; set; }
        public IService<Domain> Service { get; set; }

        public BaseController()
        {

        }

        public BaseController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public BaseController(IMapper mapper, IService<Domain> service) : this(mapper)
        {
            Service = service;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Domain> Get()
        {
            return Service.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Domain Get(int id)
        {
            return Service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Domain item)
        {
            Service.Add(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Domain item)
        {
            Service.Update(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Service.Delete(id);
        }
    }
}
