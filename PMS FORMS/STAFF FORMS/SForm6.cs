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

namespace PMS_FORMS.STAFF_FORMS
{
    public partial class SForm6 : Form
    {
        public SForm6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idx = SForm5.findname;
            foreach (Product user in ProductDL.Productlists)
            {
                if (user.Name == idx)
                {
                    user.Name = txtname.Text;
                    user.Quantity = int.Parse(txtQuantity.Text);
                    user.Price = int.Parse(txtPrice.Text);
                }
            }
            ProductDL.PutProductdataintofile();
            this.Close();
        }
    }
}
