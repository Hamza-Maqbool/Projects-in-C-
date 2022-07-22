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

namespace PMS_FORMS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length >= 7)
            {
                label2.Visible = false;
                Staff newstaff = new Staff(txtname.Text, txtMobile.Text, txtID.Text, txtDuty.Text);
                StaffDL.addstaffintoList(newstaff);
                StaffDL.Putstaffdataintofile();
                this.Close();
            }
            else
            {
                label2.Visible = true; 
            }
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 7)
            {
                label2.Visible = false;
                Staff newstaff = new Staff(txtname.Text, txtMobile.Text, txtID.Text, txtDuty.Text);
                StaffDL.addstaffintoList(newstaff);
                StaffDL.Putstaffdataintofile();
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
