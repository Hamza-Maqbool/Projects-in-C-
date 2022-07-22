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
    public partial class SForm2 : Form
    {
        public SForm2()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductDL.Productlists;
            dataGridView1.Refresh();
        }
        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            flowLayoutPanel1.Visible = true;
            dataGridView1.DataSource = ProductDL.Productlists;
            dataBind();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SForm3 f = new SForm3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SForm4 f = new SForm4();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SForm5 f = new SForm5();
            f.Show();
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            ProductDL.Productlists.Sort((x, y) => x.Price.CompareTo(y.Price));
            dataBind();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
