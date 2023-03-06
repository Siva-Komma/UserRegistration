using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTestCases
{
    public class UserRegistrationMSTesting
    {
        public bool FirstNameTestcase(string input)
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid FirstName", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid FirstName", input);
                return false;
            }
        }
        public bool LastNameTestcase(string input)
        {
            string Pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid ", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", input);
                return false;
            }
        }
        public bool EmailValidation(string input)
        {
            string Pattern = "^[A-Za-z0-9]{3,}?([.][a-z0-9]{1,})*@[a-z]{2,}[.][a-z]{2,}?([.][a-z]{2,})?$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid Email ", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid Email", input);
                return false;
            }
        }
        public bool MobileValidation(string input)
        {
            string Pattern = "^[0-9]{2}[ ][1-9]{1,}[0-9]{9}$";;
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid Mobile Number", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid Mobile Number", input);
                return false;
            }
        }
        public bool PasswordMinimumlength(string input)
        {
            string Pattern = "^[A-Za-z0-9@,.#*$&]{8,}$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid ", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", input);
                return false;
            }
        }
    }

}
