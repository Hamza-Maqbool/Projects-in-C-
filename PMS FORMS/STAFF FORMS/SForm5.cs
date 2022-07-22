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
    public partial class SForm5 : Form
    {
        public static string findname;
        public SForm5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool find = ProductDL.EditProductFromList(txtID.Text);
            if (find == true)
            {
                label1.Visible = false;
                findname = txtID.Text;
                SForm6 f = new SForm6();
                f.Show();
                this.Hide();
            }
            else
            {
                label1.Visible = true;
            }
        }
    }
}
