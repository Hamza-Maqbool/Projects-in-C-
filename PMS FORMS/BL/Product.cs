using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_FORMS.BL
{
    class Product
    {
        private string name;
        private int quantity;
        private int price;
       

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
       

        public Product(string Pname, int price, int quantity)
        {
            this.name = Pname;
            this.Price = price;
            this.Quantity = quantity;

        }
        public Product()
        {

        }
      
    }
}

