using Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace Domain
{
    public static class DataAccess
    {
        private static readonly string personTextFile = "PersonText.txt";

        public static void AddNewPerson(PersonModel person)
        {
            List<PersonModel> people = GetAllPeople();

            AddPersonToPeopleList(people, person);

            List<string> lines = ConvertModelsToCSV(people);

            File.WriteAllLines(personTextFile, lines);
        }

        public static void AddPersonToPeopleList(List<PersonModel> people, PersonModel person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
#pragma warning disable CA2208 // Instantiate argument exceptions correctly
                throw new ArgumentException("You passed in an invalid parameter", "FirstName");
#pragma warning restore CA2208 // Instantiate argument exceptions correctly
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
#pragma warning disable CA2208 // Instantiate argument exceptions correctly
                throw new ArgumentException("You passed in an invalid parameter", "LastName");
#pragma warning restore CA2208 // Instantiate argument exceptions correctly
            }

            people.Add(person);
        }

        public static List<string> ConvertModelsToCSV(List<PersonModel> people)
        {
            List<string> output = new();

            foreach (PersonModel user in people)
            {
                output.Add($"{ user.FirstName },{ user.LastName }");
            }

            return output;
        }

        public static List<PersonModel> GetAllPeople()
        {
            List<PersonModel> output = new();
            string[] content = File.ReadAllLines(personTextFile);

            foreach (string line in content)
            {
                string[] data = line.Split(',');
                output.Add(new PersonModel { FirstName = data[0], LastName = data[1] });
            }

            return output;
        }
    }
}
