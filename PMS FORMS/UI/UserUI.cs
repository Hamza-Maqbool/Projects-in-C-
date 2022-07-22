using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_FORMS.UI
{
    class UserUI
    {
        public static char user_option(char option)
        {
            Console.WriteLine(" 1. VIEW AVAILABLE PRODUCTS AND PRICE.");
            Console.WriteLine(" 2. VEIW DISCOUNTED PRODUCTS.");
            Console.WriteLine(" 3. BUY THE PRODUCT.");
            Console.WriteLine(" 4. VEIW THE BILL.(IF HE/SHE SHOPING MORE THAN 1000 HE/SHE WILL GET 30% DISCOUNT)");
            Console.WriteLine(" 5. RETURN THE PRODUCT.");
            Console.WriteLine(" 6. TO GO BACK.");
            Console.WriteLine("  SELECT YOUR OPTION.......... ");
            option = char.Parse(Console.ReadLine());
            return option;
        }
    }
}
