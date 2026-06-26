using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IPersonRepository
    {
        bool IsPerson(int id);
        int AddPerson(person person);
        person SearchPersonByID(int ID);
        List<person> SearchPersonByName(string Name);
        List<person> ViewAllPersons();
        bool UpdatePersonData(int id, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null);
        bool RemovePerson(int id);
    }
}
