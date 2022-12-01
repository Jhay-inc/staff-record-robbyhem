using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff
{
    public static class UserInput
    {
        public static void ClickEnterToContinue()
        {
            Console.WriteLine("Click \"enter\" to continue");
            Console.ReadKey();
            //Console.Clear();
        }

        public static string GetSecretPassword(string prompt)
        {
            bool isPrompt = true;
            string asterics = "";

            StringBuilder inpuut = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                ConsoleKeyInfo inputKey = Console.ReadKey(true);

            }
}


        


        public static void GetDetails()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            while (!Validate.IsValidName(firstName))
            {
                Console.Clear();
                Console.Write("Invalid Entry, Name must begin with capital letters! \nLast Name: ");
                firstName = Console.ReadLine();
            }

            Console.WriteLine();
            
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            while (!Validate.IsValidName(lastName))
            {
                Console.Clear();
                Console.Write("Invalid Entry, Name must begin with capital letters! \nLast Name: ");
                lastName = Console.ReadLine();
            }

            Console.WriteLine();

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
                Console.Write("Password should contain minimum of 6 alphanumeric and special characters! \n Password? ");
                password = Console.ReadLine();
            }

            Console.WriteLine();

            Console.Write("Department: ");
            string department = Console.ReadLine();

            while (!Validate.IsValidName(department))
            {
                Console.Clear();
                Console.Write("Invalid Entry, Department must begin with capital letters! \n Department: ");
                department = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Date: ");
            DateTime date;
            bool isValid = DateTime.TryParse(Console.ReadLine(), out date);

            if (isValid)
            {
                Console.WriteLine("Press \"enter\" to submit");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("you entered an invalid date");
                Console.WriteLine();
            }
        }

        
    }
}
