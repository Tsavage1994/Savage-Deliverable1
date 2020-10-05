using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean passwordIsValid = true;
            Boolean hasCap = false;
            Boolean hasLower = false;

            Console.WriteLine("What is your password?");
            string password = Console.ReadLine();
            int passwordLength = 0;
            foreach (char t in password)
            {
                passwordLength++;
            }


            if (passwordLength < 7)
            {
                passwordIsValid = false;
            }


            if (passwordLength > 12)
            {
                passwordIsValid = false;
            }


            foreach (char a in password)
            {
                if (a != '!')
                {
                    passwordIsValid = false;

                }

            }

            foreach (char x in password)
            {
                if (Char.IsUpper(x))
                {
                    hasCap = true;

                }
                if (Char.IsLower(x))
                {
                    hasLower = true;
                }

            }
            if (hasCap == false)
            {
                passwordIsValid = false;

            }
            if (hasLower == false)
            {
                passwordIsValid = false;
            }

            if (passwordIsValid == true)
            {
                Console.WriteLine("Password is valid and excepted.");
            }
            else
            {
                Console.WriteLine("Password not accepted.");
            }
        }
                
        
    }
}
