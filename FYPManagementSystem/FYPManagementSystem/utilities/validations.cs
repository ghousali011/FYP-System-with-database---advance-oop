using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;

namespace FYPManagementSystem.utilities
{
    internal class validations
    {
        // email validation
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        // contact validation
        public static bool IsValidPakPhone(string phone)
        {
            string pattern = @"^(?:\+92|92|0)?3\d{9}$";
            return Regex.IsMatch(phone, pattern);
        }
        // date validations
        public static bool IsValidDOB(string dob)
        {
            dob = dob.Trim();
            DateTime? DOB = converToDate(dob);
            if (!DOB.HasValue) return false;
            DateTime today = DateTime.Today;
            int age = today.Year - DOB.Value.Year;

            if (DOB > today)
                return false;
            if (age < 16)
                return false;
            return true;
        }
        public static bool isValidDate(string date)
        {
            date = date.Trim();
            return converToDate(date).HasValue;
        }
        public static DateTime? converToDate(string date)
        {
            DateTime Date;
            if (DateTime.TryParse(date, out Date))
            {
                return Date;
            }
            return null;
        }
        // registration no validation
        public static bool IsValidRegNo(string regNo)
        {
            regNo = regNo.Trim();
            if (!isValidString(regNo)) return false;
            string pattern = @"^\d{4}-[a-zA-Z]+-\d+$";
            return Regex.IsMatch(regNo, pattern);
        }
        // empty string validation
        public static bool isValidString(string str)
        {
            str = str.Trim();
            return (!str.IsNullOrEmpty());
        }
        public static bool isValidNumber(string str)
        {
            str = str.Trim();
            try
            {
                int.Parse(str);
                return (!str.IsNullOrEmpty() );

            } catch { return false; }
        }
        public static bool isValidFloat(string str)
        {
            str = str.Trim();
            try
            {
                float.Parse(str);
                return (!str.IsNullOrEmpty());

            }
            catch { return false; }
        }
    }
}
