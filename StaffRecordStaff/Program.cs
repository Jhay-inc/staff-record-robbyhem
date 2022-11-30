using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "STAFF RECORD";
            
            Console.WriteLine("----------------------------Welcome To Robby School Staff Records----------------------------");

            Console.WriteLine("Click \"enter\" to continue");
            Console.ReadKey();
            //Console.Clear();

            Console.WriteLine("Enter [1] to register, [2] to login or [3] to exit");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();

            UserInputs userInputs = new UserInputs();
            Login login = new Login();
            switch (option)
            {
                case 1:
                    userInputs.Register();
                    break;

                case 2:
                    login.Details();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid Entry..");
                    break;
            }


            
           

            //if (selection == 1)
            //{
            //    Console.WriteLine();
            //    SignupAccount signupAccount = new SignupAccount();
            //    signupAccount.GetRegistrationInfo();
            //}
            //else if (selection == 2)
            //{
            //    Console.WriteLine();
            //    Login login = new Login();
            //    login.Details();
            //}
            //else if (selection == 3)
            //{
            //    Console.WriteLine();
            //    Console.Write("Goodbye!");
            //}
        }
    }
}
