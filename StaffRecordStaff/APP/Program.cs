using StaffRecordStaff.WelcomeLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff.APP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Greet.Welcome();

            Console.WriteLine();

            Console.WriteLine("Enter [1] to register, [2] to login or [3] to exit");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();

            UserLogin login = new UserLogin();
            switch (option)
            {
                case 1:
                    UserInput.GetDetails();
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
        }
    }
}
