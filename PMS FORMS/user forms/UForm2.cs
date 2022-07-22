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
    public partial class UForm2 : Form
    {

        public UForm2()
        {
            InitializeComponent();
        }
        public static int Quantity;

        private void button1_Click(object sender, EventArgs e)
        {
            Quantity = int.Parse(txtQuantity.Text);

            this.Close();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
