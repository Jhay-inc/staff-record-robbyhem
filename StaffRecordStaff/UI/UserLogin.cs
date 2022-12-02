using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff
{
    public class UserLogin
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
            SecureString pass = new SecureString();
            ConsoleKeyInfo keyInfo;


            do
            {
                keyInfo = Console.ReadKey(true);
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    pass.AppendChar(keyInfo.KeyChar);
                    Console.Write("*");
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            
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
