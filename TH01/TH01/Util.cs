using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TH01
{
    internal static class Util
    {
        public static bool isBirthdayValid(DateTime bd)
        {
            int age = DateTime.Now.Year - bd.Year;
            return age >= 18;
        }
        public static bool isMailValid(string str)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(str, emailPattern);
        }
        public static bool isPhoneNoValid(string str)
        {
            string phonePattern = @"^\d{3}-\d{4}-\d{3}$";
            return Regex.IsMatch(str, phonePattern);
        }
        public static bool isEmpty(string str)
        {
            return str.Length == 0;
        }
        public static bool isFullInfo(Person person)
        {
            if (isEmpty(person.Name) || isEmpty(person.Address) || isEmpty(person.Id) || !isMailValid(person.Email) || !isPhoneNoValid(person.Phone) || isEmpty(person.Gender) || !isBirthdayValid(person.Birth))
                return false;
            return true;
        }
    }
}
