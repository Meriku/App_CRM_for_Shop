using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public partial class AddProduct : Form
    {
        public Product Product { get; set; }

        public AddProduct()
        {
            InitializeComponent();
        }
        public AddProduct(Product product) : this()
        {

            Product = product ?? new Product();

            textBoxName.Text = product.Name;
            numericUpDown1.Value = product.Price;
            numericUpDown2.Value = product.Count;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal price = numericUpDown1.Value;
            int count = (int)numericUpDown2.Value;


          
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Некорректное значение.";
            }
            else 
            {
                Product = Product ?? new Product();

                Product.Name = textBoxName.Text;
                Product.Price = price;
                Product.Count = count;

                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
