using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidateRegex
{
    public class ValidatePinCode
    {
        public const string PinCode = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";//string starts with ^ ends with $
        public void Validate(string pinCode)
        {
            if(Regex.IsMatch(pinCode, PinCode))
            {
                Console.WriteLine("Validation is success");
            }
            else
            {
                Console.WriteLine("Validation is  not success");
            }
        }

    }
}
