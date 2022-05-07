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
    public partial class AddCustomer : Form
    {
        public Customer Customer { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }

        public AddCustomer(Customer customer) : this()
        {
            Customer = customer ?? new Customer();

            textBox1.Text = Customer.Name;
        }
        


        private void button1_Click(object sender, EventArgs e)
        {

            Customer = Customer ?? new Customer();

            Customer.Name = textBox1.Text;

            Close();

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
