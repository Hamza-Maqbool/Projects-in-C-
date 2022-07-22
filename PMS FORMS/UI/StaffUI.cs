using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_FORMS.UI
{
    class StaffUI
    {
        public static char staff_option(char option)
        {
            Console.WriteLine(" 1. ADD PRODUCT.");
            Console.WriteLine(" 2. DELETE PRODUCT.");
            Console.WriteLine(" 3. SORT THE PRODUCT.");
            Console.WriteLine(" 4. CHECK QUANTITY OF PRODUCT.");
            Console.WriteLine(" 5. TO GO BACK.");
            Console.WriteLine("  SELECT YOUR OPTION.......... ");
            option = char.Parse(Console.ReadLine());
            return option;
        }
    }
}
