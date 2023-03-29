using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class ValidateEmailID
    {
        public const string EMAIL = "^[0-9A-Za-z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public void ValidateEmail(string email)
        {
            if(Regex.IsMatch(email,EMAIL))
            {
                Console.WriteLine("Validation of email is success");
            }
            else
            {
                Console.WriteLine("Validation of email is unsuccess");
            }
        }
    }
}
