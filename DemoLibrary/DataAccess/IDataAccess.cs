using System.Collections.Generic;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModels> GetPeople();
        PersonModels InsertPerson(string firstName, string lastName);
    }
}