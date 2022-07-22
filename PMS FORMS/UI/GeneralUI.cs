using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_FORMS.UI
{
    class GeneralUI
    {
        public static void header()
        {
            Console.WriteLine("                                                    ");
            Console.WriteLine("   *********************************************** ");
            Console.WriteLine("             PHARMACY MANAGEMENT SYSTEM            ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("   ***********************************************");
            Console.WriteLine("                                                  ");
        }
        public static char main_manu(char option)
        {
            Console.WriteLine("  LOGIN AS ADMIN ");
            Console.WriteLine("  PRESS  1.      ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("  LOGIN AS STAFF MEMBER  ");
            Console.WriteLine("  PRESS  2.      ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("  LOGIN AS USER      ");
            Console.WriteLine("  PRESS  3.      ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("  EXIT           ");
            Console.WriteLine("  PRESS 4.       ");
            Console.WriteLine("                                             ");
            Console.WriteLine("  SELECT YOUR OPTION.......... ");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static char admin_option(char option)
        {
            Console.WriteLine(" 1. SELECT  PHARMACY NAME.");
            Console.WriteLine(" 2. VEIW  PHARMACY NAME.");
            Console.WriteLine(" 3. ADD STAFF MEMBER.");
            Console.WriteLine(" 4. VIEW STAFF MEMBER.");
            Console.WriteLine(" 5. DELETE STAFF MEMBER.");
            Console.WriteLine(" 6. VIEW PRODUCT LIST.");
            Console.WriteLine(" 7.  TO GO BACK");
            Console.WriteLine("  SELECT YOUR OPTION.......... ");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void clearsceern()
        {
            Console.WriteLine("PRESS ANY KEY TO CONTIUNE......");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
