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
        public void LastName()
        {
            string Pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            string[] LastName = { "Komma","venky","Karthik","HelloWorld" ,"Hello World"};

            foreach (string input in LastName)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
        public void ValidEmail()
        {
            string Pattern = "^[a-zA-z]{3,}?([.][a-z0-9]{1,})*@[a-z]{2,}[.][a-z]{2,}?([.][a-z]{2,})?$";
            string[] Email = {"abc.xyz@bl.co.in","Sivakomma@gmail.com","Komma123gmail.com","siva@.com"};

            foreach (string input in Email)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
        public void MobileFormat()
        {
            string Pattern = "^[0-9]{2}[ ][1-9]{1,}[0-9]{9}$";
            string[] Number  = {"91 9381656750","919381656750","91 0938165675","81 938165675" };

            foreach (string input in Number)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
        public void PasswordRule1()
        {
            string Pattern = "^[A-Za-z0-9@,.#*$&]{8,}$";
            string[] Password = { "Siv@329612","Siva@12","siva123","siva@123" };

            foreach (string input in Password)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
        public void PasswordRule2()
        {
            string Pattern = "^?[A-Za-z0-9]{1,}[A-Za-z0-9@,.#*$&]{7,}$";
            string[] Password = { "Siv@329612", "Siva@12", "siva@123", "9siva@123" };

            foreach (string input in Password)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
        public void PasswordRule3()
        {
            string Pattern = "^?[A-Za-z0-9]{1,}[A-Za-z0-9@,.#*$&]{7,}$";
            string[] Password = { "Siv@329612", "Siva@12", "siva123@", "9siva@123" };

            foreach (string input in Password)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} Valid Input", input);
                }
                else
                {
                    Console.WriteLine("{0} Invalid Input", input);
                }
            }
        }
    }
}
