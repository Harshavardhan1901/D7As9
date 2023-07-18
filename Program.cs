using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) 
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Registration System");
                Console.WriteLine("------------------------");

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your email: ");
                string email = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                RegisterUser(name, email, password);

                Console.WriteLine("User registration success!");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Password: " + password);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }

        static void RegisterUser(string name, string email, string password)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 6)
            {
                throw new ValidationException("Name must have at least 6 characters.");
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ValidationException("Email is required.");
            }

            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                throw new ValidationException("Password must have at least 8 characters.");
            }
            Console.ReadKey();
        }
    }
}
