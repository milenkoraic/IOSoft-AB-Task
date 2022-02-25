using System;
using System.Collections.Generic;
using Xunit;
using Domain.Entities;

namespace Domain.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new() { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new() { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
