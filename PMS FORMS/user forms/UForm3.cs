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
using PMS_FORMS.user_forms;

namespace PMS_FORMS.user_forms
{
    public partial class UForm3 : Form
    {
        public UForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                ProductDL.ReturnProduct(textBox1.Text, int.Parse(txtQuantity.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the Product");
            }

            if (ProductDL.isfound == false)
            {
                lblvalid.Visible = true;
                
            }
            else
            {
                lblvalid.Visible = false;
                this.Close();
            }
        }
    }
}
