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
using PMS_FORMS.STAFF_FORMS;
using PMS_FORMS.user_forms;

namespace PMS_FORMS
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
            if(count == 0)
            {
                StaffDL.loadStaffData();
                ProductDL.loadProductData();
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SForm1 f = new SForm1();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UForm1 f = new UForm1();
            f.Show();
            this.Hide();
        }
    }
}
