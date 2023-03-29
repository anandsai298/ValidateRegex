// See https://aka.ms/new-console-template for more information
using System;
namespace ValidateRegex;
class program
{
    static void Main(string[] arg)
    {
        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validate("400088");
        validatePinCode.Validate("A533002");
        validatePinCode.Validate("533002A");
        validatePinCode.Validate("400 088");
        ValidateEmailID validateEmailID = new ValidateEmailID();
        validateEmailID.ValidateEmail("anandsai298@gmail.com");
        validateEmailID.ValidateEmail("anandsai298@gmail.co.in");
        validateEmailID.ValidateEmail("anandsai298@gmai34l.com");
    }
}

