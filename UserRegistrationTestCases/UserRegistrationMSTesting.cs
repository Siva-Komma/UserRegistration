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
    }
}
