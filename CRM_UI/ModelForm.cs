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
    public partial class ModelForm : Form
    {

        ShopComputerModel model = new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {

            var cashBoxes = new List<CashBoxView>();

            for (var i = 1; i < model.CashDesks.Count+1; i++)
            {
                var box = new CashBoxView(model.CashDesks[i-1], i-1, 10, 26 * i);
                cashBoxes.Add(box);
                Controls.Add(box.CashDeskName);
                Controls.Add(box.Price);
                Controls.Add(box.QueueLenght);
                Controls.Add(box.LeaveCustomerCount);
            }
         

        }

        private void start_Click(object sender, EventArgs e)
        {          
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarCashDesk_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = 1050 - trackBarCashDesk.Value;
        }

        private void trackBarCustomerSpeed_Scroll(object sender, EventArgs e)
        {
            model.CustomerSpeed = 1050 - trackBarCustomerSpeed.Value;
        }
    }
}
