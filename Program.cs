using System;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            String fname = Console.ReadLine();
            LambdaFunctions obj = new LambdaFunctions();
            if (obj.validateName(fname))
            {
                Console.WriteLine("First Name Valid");
            }
            else
            {
                Console.WriteLine("First Name Invalid");
            }

            Console.WriteLine("\nEnter Last Name: ");
            String lname = Console.ReadLine();
            if (obj.validateName(lname))
            {
                Console.WriteLine("Last Name Valid");
            }
            else
            {
                Console.WriteLine("Last Name Invalid");
            }

            Console.WriteLine("\nEnter Email: ");
            Console.ReadLine();
            String email = Console.ReadLine();
            if (obj.validateEmail(email))
            {
                Console.WriteLine("Email Valid");
            }
            else
            {
                Console.WriteLine("Email Invalid");
            }

            Console.WriteLine("\nEnter Phone No with Country Code: ");
            String phone = Console.ReadLine();
            if (obj.validatePhone(phone))
            {
                Console.WriteLine("Phone No. Valid");
            }
            else
            {
                Console.WriteLine("Phone No. Invalid");
            }
            Console.WriteLine(
           "\nEnter Password (Min 8 characters with Atleast 1 Uppercase, 1 Numeric Digit, 1 Special Character): ");
            String password = Console.ReadLine();
            if (obj.validatePassword(password))
            {
                Console.WriteLine("Password Valid");
            }
            else
            {
                Console.WriteLine("Password Invalid");
            }



        }
    }
}
