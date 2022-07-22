using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_FORMS.BL;
using System.IO;
using PMS_FORMS.user_forms;

namespace PMS_FORMS.DL
{
    class ProductDL
    {
        private static List<Product> productlists = new List<Product>();

        static string path1 = "D:\\University Work\\Semester 2\\PMS\\PMS FORMS\\bin\\Debug\\Product_Info.txt";
        static int countsum;
        static int price;
        public static bool isfound;
        internal static List<Product> Productlists { get => productlists; set => productlists = value; }

        public static void addproductintoList(Product newProduct)
        {
            productlists.Add(newProduct);
        }
        public static void addproductintofile(string pname, int pprice, int pquan)
        {
            StreamWriter file = new StreamWriter(path1, true);
            file.Write(pname);
            file.Write(",");
            file.Write(pprice);
            file.Write(",");
            file.WriteLine(pquan);
            file.Flush();
            file.Close();
        }
        public static int findProduct(string newProduct)
        {
            for (int x = 0; x < Productlists.Count; x++)
            {
                if (newProduct == Productlists[x].Name)
                {
                    return x;
                }
            }
            return -1;
        }
        public static void deleteItem(string newProduct,int quan)
        {
            int idx = findProduct(newProduct);
            if (idx >= 0)
            {
                Productlists[idx].Quantity = Productlists[idx].Quantity - quan;
                if(Productlists[idx].Quantity <= 0)
                {
                    Productlists.RemoveAt(idx);
                }
            }
        }
        public static void PutProductdataintofile()
        {
            StreamWriter file = new StreamWriter(path1, false);
            for (int i = 0; i < Productlists.Count; i++)
            {
                file.Write(Productlists[i].Name);
                file.Write(",");
                file.Write(Productlists[i].Price);
                file.Write(",");
                file.WriteLine(Productlists[i].Quantity);
            }
            file.Flush();
            file.Close();
        }
        public static void loadProductData()
        {
            using (StreamReader file1 = new StreamReader(path1))
            {
                string line;
                if (File.Exists(path1))
                {
                    while ((line = file1.ReadLine()) != null)
                    {
                        string Pname;
                        int price, quantity;
                        Pname = StaffDL.parseData(line, 1);
                        price = int.Parse(StaffDL.parseData(line, 2));
                        quantity = int.Parse(StaffDL.parseData(line, 3));
                        Product productlist = new Product(Pname, price, quantity);
                        Productlists.Add(productlist);

                    }
                    file1.Close();
                }
            }

        }
        public static void ReturnProduct(string name,int quantity)
        {
           
             isfound = false;
            int increase;
            price = 0;
            
            for (int i = 0; i < Productlists.Count; i++)
            {
               
                if (name == Productlists[i].Name)
                {
                    isfound = true;
                    increase = Productlists[i].Quantity + quantity;
                    Productlists[i].Quantity = increase;
                    price = quantity * Productlists[i].Price;
                    UForm4 f = new UForm4();
                    f.textBox1.Text = price.ToString();
                    f.Show();
                   
                }
            }
            
        }
        public static bool EditProductFromList(string Productname)
        {
            int idx = findProduct(Productname);
            if (Productlists[idx].Name == Productlists[idx].Name)
            {
                return true;
            }
            return false;

        }
        public static void buytheProduct(Product newProduct , int qu)
        {
            int decrese;
            int price, j = 0;
           
            for (int index = 0; index < Productlists.Count; index++)
            {
                if (Productlists[index].Name == newProduct.Name && Productlists[index].Price == newProduct.Price)
                {
                    if (Productlists[j].Quantity >= qu)
                    {
                        decrese = Productlists[index].Quantity - qu;
                        Productlists[index].Quantity = decrese;
                        price = qu * productlists[index].Price;
                        countsum = countsum + price;
                        
                    }
                }
            } 
           
        }
        public static int generateBill()
        {
            return countsum;
        }
    }
}
