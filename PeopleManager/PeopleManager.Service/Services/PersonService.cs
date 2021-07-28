using PeopleManager.Data.Models;
using PeopleManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }
               
        public async Task<Person> GetPersonByIdAsync(Guid id)
        {
            return await _personRepository.GetAsync(id);
        }

        public async Task<Person> AddPersonAsync(Person person)
        {
             return await _personRepository.AddAsync(person);
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
            return await _personRepository.GetAllAsync();
        }

    }
}
