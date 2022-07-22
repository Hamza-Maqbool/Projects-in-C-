using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_FORMS.BL;
using System.IO;

namespace PMS_FORMS.DL
{
    class PharmacyNameDL
    {
        static string path = "D:\\University Work\\Semester 2\\PMS\\PMS FORMS\bin\\Debug\\PHARMACYNAME.txt";
        public static void AddPharmacyname()
        {
            string pname;
            StreamWriter file = new StreamWriter(path, false);
            Console.WriteLine("1. ENTER PHARMACY NAME : ");
            pname = Console.ReadLine();
            file.WriteLine(pname);
            file.Flush();
            file.Close();
        }
        public static void loadPharmacyname()
        {
            //string phar_name;
            PhamacyName name = new PhamacyName();
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                name.PmsName = line;
            }
            file.Close();
        }
    }
}
