using PeopleManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(PersonDbContext personDbContext) : base(personDbContext)
        {

        }

        public Person GetPersonByNameAsync(string name)
        {
            return Find(x => x.Name == name).FirstOrDefault();
        }
    }
}
