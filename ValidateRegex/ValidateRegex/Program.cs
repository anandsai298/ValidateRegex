// See https://aka.ms/new-console-template for more information
using System;
namespace ValidateRegex;
class program
{
    static void Main(string[] arg)
    {
        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validate("533002");
    }
}

