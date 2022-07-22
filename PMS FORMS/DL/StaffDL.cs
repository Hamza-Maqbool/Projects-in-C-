using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PMS_FORMS.BL;

namespace PMS_FORMS.DL
{
    class StaffDL
    {
        private static List<Staff> staffmembers = new List<Staff>();

        internal static List<Staff> Staffmembers { get => staffmembers; set => staffmembers = value; }

        static string path = "D:\\University Work\\Semester 2\\PMS\\PMS FORMS\\bin\\Debug\\staff_info.txt";

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static void loadStaffData()
        {
           
            StreamReader file = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string Sname = parseData(line, 1);
                    string id = parseData(line, 2);
                    string mobile = parseData(line, 3);
                    string duty = parseData(line, 4);
                    Staff Smember = new Staff(Sname, mobile, id, duty);
                    Staffmembers.Add(Smember);
                }
                file.Close();
            }

        }
        public static void Putstaffdataintofile()
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < Staffmembers.Count; i++)
            {
                file.Write(Staffmembers[i].Name);
                file.Write(",");
                file.Write(Staffmembers[i].Id);
                file.Write(",");
                file.Write(Staffmembers[i].Mobile);
                file.Write(",");
                file.WriteLine(Staffmembers[i].Duty);
            }
            file.Flush();
            file.Close();
        }
    
        public static void addstaffintoList(Staff staffmem)
        {
            Staffmembers.Add(staffmem);
            
        }
        public static void addstaffintofile(string sname, string id, string mobile, string duty)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.Write(sname);
            file.Write(",");
            file.Write(id);
            file.Write(",");
            file.Write(mobile);
            file.Write(",");
            file.WriteLine(duty);
            file.Flush();
            file.Close();
        }
        public static void deletestaff(string newStaff)
        {
            int idx = findStaff(newStaff);
            if (idx >= 0)
            {
                staffmembers.RemoveAt(idx);
            }
        }
        public static int findStaff(string newStaff)
        {
            for (int x = 0; x < staffmembers.Count; x++)
            {
                if (newStaff == staffmembers[x].Id)
                {
                    return x;
                }
            }
            return -1;
        }
        public static bool loginMenu(string username, string pass)
        {
            
            for (int i = 0; i < Staffmembers.Count; i++)
            {
                if (Staffmembers[i].Name == username && Staffmembers[i].Id == pass)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool EditStaffFromList(string newStaff)
        {
            int idx = findStaff(newStaff);
            
                if (Staffmembers[idx].Id == Staffmembers[idx].Id)
                {
                    return true;
                }

            return false;

        }
    }
}
