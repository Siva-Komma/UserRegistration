using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Registration
    {
        public void FirstName()
        {
             string Pattern = "^[A-Z]{1}[a-z]{2,}$";
             string[] FirstName = {"Siva","Komma","Sai","sai","siva","Hi"};
         
            foreach (string input in FirstName)
            {
                if(Regex.IsMatch(input,Pattern))
                {
                    Console.WriteLine("{0} Valid Input",input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input",input);
                }
            }
        }
    }
}
