using Microsoft.EntityFrameworkCore;
using Moq;
using PeopleManager.Data.Models;
using PeopleManager.Data.Repositories;
using System;
using Xunit;

namespace PeopleManager.Data.Tests
{
    public class PersonRepositoryTests
    {
        [Fact]
        public async void AddPerson_Should_AddAPerson()
        {
            //Arrange
            var person = new Person();

            var context = new Mock<PersonDbContext>();
            var dbSet = new Mock<DbSet<Person>>();
            context.Setup(x => x.Set<Person>()).Returns(dbSet.Object);


            //Act
            var repo = new PersonRepository(context.Object);
            await repo.AddAsync(person);

            //Assert
            context.Verify(x => x.Set<Person>());
            dbSet.Verify(x => x.Add(It.Is<Person>(y => y == person)));
        }

        [Fact]
        public void Remove_TestClassObjectPassed_ProperMethodCalled()
        {
            //Arrange
            var person = new Person();

            var context = new Mock<PersonDbContext>();
            var dbSet = new Mock<DbSet<Person>>();
            context.Setup(x => x.Set<Person>()).Returns(dbSet.Object);

            //Act
            var repo = new PersonRepository(context.Object);
            repo.Remove(person);

            //Assert
            context.Verify(x => x.Set<Person>());
            dbSet.Verify(x => x.Remove(It.Is<Person>(y => y == person)));
        }
    }
}
