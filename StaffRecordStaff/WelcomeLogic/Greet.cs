using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordStaff.WelcomeLogic
{
    public class Greet
    {
        public static void Welcome()
        {
            Console.Title = "STAFF RECORD";

            Console.WriteLine("===><===><===><===><===><===><===Welcome To Robby School Staff Records===><===><===><===><===><===><===");
            
            UserInput.ClickEnterToContinue();
        }

        
    }
}
