using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff
{
    public class Login
    {
        public void Details()
        {

            Console.Write("Email Address: ");
            string emailAddress = Console.ReadLine();
            while (!Validate.IsValidMail(emailAddress))
            {
                Console.Clear();
                Console.Write("Invalid Entry! Email Address: ");
                emailAddress = Console.ReadLine();
            }

            Console.WriteLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();
            while (!Validate.IsValidPassword(password))
            {
                Console.Clear();
                Console.Write("Password should contain minimum of 6 alphanumeric and special characters! \n Password: ");
                password = Console.ReadLine();
            }
        }
    }
}
