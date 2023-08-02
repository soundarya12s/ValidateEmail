using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidation
{
    public class ValidateEmail
    {
        string actual = "^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]+[@]{1}[a-zA-Z0-9]+[.]{1}[a-zA-Z0-9]{2,3}([.]{1}[a-zA-Z0-9]{2}){0,1}$";
        public void Validate(string input)
        {
            bool result = Regex.IsMatch(input, actual);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }

    }
}
