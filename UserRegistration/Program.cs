using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("1.Validate FirstName");
            Console.WriteLine("Choose your Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            Registration registration = new Registration(); 
            switch(Option)
            {
                case 1:
                    registration.FirstName();
                    break;
            }
            Console.ReadLine();
        }
    }
}
