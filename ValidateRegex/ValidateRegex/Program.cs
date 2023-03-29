// See https://aka.ms/new-console-template for more information
using System;
namespace ValidateRegex;
class program
{
    static void Main(string[] arg)
    {
        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validate("400088");//pass
        validatePinCode.Validate("A533002");//fail
        validatePinCode.Validate("533002A");//fail
        validatePinCode.Validate("400 088");//pass
        ValidateEmailID validateEmailID = new ValidateEmailID();
        validateEmailID.ValidateEmail("anandsai298@gmail.com");//pass
        validateEmailID.ValidateEmail("anandsai298@gmail.co.in");//pass
        validateEmailID.ValidateEmail("anandsai298@gmai34l.com");//fail
        ValidateRegistration validateRegistration = new ValidateRegistration();
        validateRegistration.Validate_FN("Abc");//pass
        validateRegistration.Validate_FN("ab");//fail
        validateRegistration.Validate_FN("Abac");//pass
        validateRegistration.Validate_LN("Ask");//pass
        validateRegistration.Validate_LN("ask");//fail
        validateRegistration.Validate_LN("Anand");//pass
        validateRegistration.Validate_PhNo("9550631687");//pass
        validateRegistration.Validate_PhNo("4789251578");//fail
        validateRegistration.Validate_EmailId("anand298@gmail.co.in");//pass
        validateRegistration.Validate_EmailId("Ask143@gmail7.com");//fail
        validateRegistration.Validate_Password("Here1234");//fail
        validateRegistration.Validate_Password("Here#123");//pass
        validateRegistration.Validate_Password("ASKAR143");//fail
        validateRegistration.Validate_Password("Here@1234");//pass
    }
}

