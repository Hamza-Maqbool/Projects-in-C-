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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StaffDL.Staffmembers;
            dataGridView1.Refresh();
        }
        public void dataBindProduct()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductDL.Productlists;
            dataGridView1.Refresh();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            flowLayoutPanel1.Visible = true;
            dataGridView1.DataSource = StaffDL.Staffmembers;
            dataBind();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            dataBind();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            tableLayoutPanel1.Visible = true;
            flowLayoutPanel1.Visible = false;
            dataGridView1.DataSource = ProductDL.Productlists;
            dataBindProduct();
        }
    }
}
