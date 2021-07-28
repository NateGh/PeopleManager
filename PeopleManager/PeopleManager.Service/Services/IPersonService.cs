using PeopleManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Service.Services
{
    public interface IPersonService
    {
        Task<Person> GetPersonByIdAsync(Guid id);
        Task<Person> AddPersonAsync(Person person);
        Task<IEnumerable<Person>> GetAllPersonsAsync();


    }
}
