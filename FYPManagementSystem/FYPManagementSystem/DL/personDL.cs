using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class personDL
    {
        public static bool isperson(int id)
        {
            return DLFactory.PersonRepository.IsPerson(id);
        }

        public static int addperson(person person)
        {
            try
            {
                return DLFactory.PersonRepository.AddPerson(person);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        public static person searchpersonbyID(int ID)
        {
            return DLFactory.PersonRepository.SearchPersonByID(ID);
        }

        public static List<person> searchpersonbyName(string Name)
        {
            return DLFactory.PersonRepository.SearchPersonByName(Name);
        }

        public static List<person> viewAllpersons()
        {
            return DLFactory.PersonRepository.ViewAllPersons();
        }

        public static bool updatePersonData(int id, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            try
            {
                return DLFactory.PersonRepository.UpdatePersonData(id, FirstName, Email, LastName, Contact, DateOfBirth, gender);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public static bool removeperson(int id)
        {
            return DLFactory.PersonRepository.RemovePerson(id);
        }
    }
}
