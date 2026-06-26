    using FYPManagementSystem.Model;
    using System;
    using System.Collections.Generic;

    namespace FYPManagementSystem.DL
    {
        internal class AdvisorDL
        {
            public static bool isAdvisor(int id)
            {
                var advisor = DLFactory.AdvisorRepository.SearchAdvisorByID(id);
                return advisor != null;
            }

            public static bool addAdvisor(Advisor Advisor)
            {
                try
                {
                    return DLFactory.AdvisorRepository.AddAdvisor(Advisor);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Error " + e);
                    return false;
                }
            }

            public static Advisor searchAdvisorbyID(int ID)
            {
                return DLFactory.AdvisorRepository.SearchAdvisorByID(ID);
            }

            public static List<Advisor> searchAdvisorbyName(string Name)
            {
                return DLFactory.AdvisorRepository.SearchAdvisorByName(Name);
            }

            public static List<Advisor> viewAllAdvisors()
            {
                return DLFactory.AdvisorRepository.ViewAllAdvisors();
            }

            public static bool updateAdvisorData(int id, string designation = null, float? salary = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
            {
                try
                {
                    return DLFactory.AdvisorRepository.UpdateAdvisorData(id, designation, salary, FirstName, Email, LastName, Contact, DateOfBirth, gender);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error:" + ex);
                    return false;
                }
            }

            public static bool removeAdvisor(int id)
            {
                try
                {
                    return DLFactory.AdvisorRepository.RemoveAdvisor(id);
                }
                catch
                {
                    return false;
                }
            }
        }
    }
