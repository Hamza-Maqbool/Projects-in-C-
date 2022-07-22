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
    public partial class Form7 : Form
    {
        string idx;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 7)
            {
                label2.Visible = false;
                idx = Form6.findid;
                foreach (Staff user in StaffDL.Staffmembers)
                {
                    if (user.Id == idx)
                    {
                        user.Name = txtname.Text;
                        user.Id = txtID.Text;
                        user.Mobile = txtMobile.Text;
                        user.Duty = txtDuty.Text;
                    }
                }
                 this.Close();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
