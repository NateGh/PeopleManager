using Microsoft.AspNetCore.Mvc;
using PeopleManager.Data.Models;
using PeopleManager.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            this._personService = personService;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return await _personService.GetAllPersonsAsync();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<Person> Get(Guid id)
        {
            return await _personService.GetPersonByIdAsync(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<Person> Post([FromBody] Person person)
        {
            return await _personService.AddPersonAsync(person);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
