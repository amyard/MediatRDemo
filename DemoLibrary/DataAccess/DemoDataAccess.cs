using System.Collections.Generic;
using System.Linq;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModels> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModels { Id = 1, FirstName = "Max", LastName = "Awesome"});
            people.Add(new PersonModels { Id = 2, FirstName = "Nikita", LastName = "Loloev"});
        }

        public List<PersonModels> GetPeople()
        {
            return people;
        }

        public PersonModels InsertPerson(string firstName, string lastName)
        {
            PersonModels p = new PersonModels {FirstName = firstName, LastName = lastName};
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);

            return p;
        }
    }
}
