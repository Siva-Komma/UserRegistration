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
            Console.WriteLine("1.Validate FirstName\n2.Validate LastName\n3.Vali EmilId\n4.MobileFormat\n5.PasswordRule1\n6.PasswordRule2\n7.PasswordRule3\n8.PasswordRul4");
            Console.WriteLine("Choose your Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            Registration registration = new Registration(); 
            switch(Option)
            {
                case 1:
                    registration.FirstName();
                    break;
                case 2: 
                    registration.LastName(); 
                    break;
                case 3:
                    registration.ValidEmail();
                    break;
                case 4:
                    registration.MobileFormat(); 
                    break;
                case 5:
                    registration.PasswordRule1();
                    break;
                case 6:
                    registration.PasswordRule2();
                    break;
                case 7:
                    registration.PasswordRule3();
                    break;
                case 8:
                    registration.PasswordRule4();
                    break;
            }
            Console.ReadLine();
        }
    }
}
