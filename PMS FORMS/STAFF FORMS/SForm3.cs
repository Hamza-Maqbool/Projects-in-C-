using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_FORMS.BL;
using PMS_FORMS.DL;
using PMS_FORMS;

namespace PMS_FORMS.STAFF_FORMS
{
    public partial class SForm3 : Form
    {
        public SForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Product newproduct = new Product(txtname.Text, int.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));
                ProductDL.addproductintoList(newproduct);
                ProductDL.PutProductdataintofile();
                this.Close();
        }
    }
}
