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
    public partial class AddSeller : Form
    {
        public Seller Seller { get; set; }

        public AddSeller()
        {
            InitializeComponent();
        }

        public AddSeller(Seller seller) : this()
        {
            Seller = seller ?? new Seller();

            textBox1.Text = Seller.Name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();

            Seller.Name = textBox1.Text;
           
            Close();
        }

        private void AddSeller_Load(object sender, EventArgs e)
        {

        }
    }
}
