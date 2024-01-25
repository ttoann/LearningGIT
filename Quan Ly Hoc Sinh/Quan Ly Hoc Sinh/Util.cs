using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh
{
    internal static class Util
    {
        public static bool isEmpty(string str)
        {
            return str.Length == 0;
        }
        public static bool isBirthdayValid(DateTime bd)
        {
            int age = DateTime.Now.Year - bd.Year;
            return age >= 18;
        }
        public static bool isMailValid(string str)
        {
            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
            Regex regex = new Regex(emailRegex, RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }
        public static bool isPhoneNoValid(string str)
        {
            string phoneRegex = @"^\(?\d{3}\)?[- ]?\d{3}[- ]?\d{4}$";
            Regex regex = new Regex(phoneRegex);
            return regex.IsMatch(str);
        }
        public static bool isFullInfo(Person person)
        {
            if (isEmpty(person.Name) || isEmpty(person.Address) || isEmpty(person.ID) || !isMailValid(person.Mail) || !isPhoneNoValid(person.Phone) || isEmpty(person.Gender) || !isBirthdayValid(person.Birthday))
                return false;
            return true;
        }
    }
}
