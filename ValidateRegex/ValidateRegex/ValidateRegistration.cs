using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidateRegex
{
    public class ValidateRegistration
    {
        public static string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string PHONE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_ID = "^[0-9A-Za-z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string PASSWORD = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$%&*+]).{8,}$";
        public void Validate_FN(string fn)
        {
            if (Regex.IsMatch(fn, NAME))
            {
                Console.WriteLine("Validation of first name is success");
            }
            else
                Console.WriteLine("validation of First name is Unsuccessfull");
        }
        public void Validate_LN(string ln)
        {
            if (Regex.IsMatch(ln, NAME))
            {
                Console.WriteLine("Validation of last name is success");
            }
            else
                Console.WriteLine("validation of last name is Unsuccessfull");
        }
        public void Validate_PhNo(string phno)
        {
            if (Regex.IsMatch(phno, PHONE_NUMBER))
            {
                Console.WriteLine("Validation of phone number is success");
            }
            else
                Console.WriteLine("validation of phone number is Unsuccessfull");
        }
        public void Validate_EmailId(string email)
        {
            if (Regex.IsMatch(email, EMAIL_ID))
            {
                Console.WriteLine("Validation of EMAIL_ID is success");
            }
            else
                Console.WriteLine("validation of EMAIL_ID is Unsuccessfull");
        }
        public void Validate_Password(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
            {
                Console.WriteLine("Validation of password is success");
            }
            else
                Console.WriteLine("validation of password is Unsuccessfull");
        }
    }
}
