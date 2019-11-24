using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsCatalogue.Contracts;
using CarsCatalogue.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarsCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        // readonly RepositoryContext _context;
        
        public ValuesController(IRepositoryWrapper  iRepositoryWrapper)
        {
            //_context = context;
            _repositoryWrapper = iRepositoryWrapper;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var domesticAccounts = _repositoryWrapper.Car.FindByCondition(x => x.Model.Equals("Domestic"));
           // var cars = _repositoryWrapper.Car.FindAll();
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}