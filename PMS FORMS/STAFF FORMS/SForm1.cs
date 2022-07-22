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
    public partial class SForm1 : Form
    {
        public SForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool find = StaffDL.loginMenu(textBox2.Text, textBox1.Text);
            if (textBox1.Text.Length >= 7 && find == true)
            {
                label3.Visible = false;
                SForm2 f = new SForm2();
                f.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
