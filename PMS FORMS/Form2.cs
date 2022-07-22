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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "007")
            {
                label3.Visible = false;
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            else if (textBox1.Text != "007")
            {
                label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1 F = new Form1();
            this.Close();
            F.Show();
        }
    }
}
