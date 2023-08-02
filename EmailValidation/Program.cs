using System;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateEmail validateEmail = new ValidateEmail();
            Console.WriteLine("Enter the Email to be validated:");
            string input = Console.ReadLine();
            validateEmail.Validate(input);
        }
    }
}