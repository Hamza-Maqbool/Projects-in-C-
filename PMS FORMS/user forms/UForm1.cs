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

namespace PMS_FORMS.user_forms
{
    public partial class UForm1 : Form
    {
       
        public UForm1()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductDL.Productlists;
            dataGridView1.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            dataGridView1.DataSource = ProductDL.Productlists;
            QuantityTEXT.Visible = true;
            dataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
                Product buyProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
                if (dataGridView1.Columns["Buy"].Index == e.ColumnIndex)
                {
                   try
                   {
                   
                    int quantity = int.Parse(QuantityTEXT.Text);
                    ProductDL.buytheProduct(buyProduct, quantity);
                    ProductDL.PutProductdataintofile();
                    dataBind();
                   }
                   catch(Exception)
                   {
                       MessageBox.Show("Please Enter Quantity");
                   }
                  
                }
           
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
             
            UForm3 f = new UForm3();
            f.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            UForm5 f = new UForm5();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
