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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            StaffDL.deletestaff(txtID.Text);
            this.Hide();
            StaffDL.Putstaffdataintofile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }
    }
}
