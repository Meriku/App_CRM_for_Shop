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
    public partial class Login : Form
    {
        public string UserName { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                UserName = textBox1.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                textBox1.Text = "Введите имя";
            }
        }
    }
}
