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

namespace PMS_FORMS
{
    public partial class Form6 : Form
    {
        public static string findid;
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool find = StaffDL.EditStaffFromList(txtID.Text);
            if(find == true)
            {
                label1.Visible = false;
                findid = txtID.Text;
                Form7 f = new Form7();
                f.Show();
                this.Hide();
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
