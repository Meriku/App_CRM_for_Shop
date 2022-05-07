using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public class CashBoxView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }    
        public Label LeaveCustomerCount { get; set; }

        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName = new Label();
            Price = new NumericUpDown();
            QueueLenght = new ProgressBar(); 
            LeaveCustomerCount = new Label();

            // label1
            // 
            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "label"+number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number; 
            CashDeskName.Text = cashDesk.ToString();
   
            // numericUpDown1
            // 
            Price.Location = new System.Drawing.Point(x + 70, y);
            Price.Name = "numericUpDown" + number;
            Price.Size = new System.Drawing.Size(120, 20);
            Price.TabIndex = number;
            Price.Maximum = 999999999999;

            // progressBar1
            // 
            QueueLenght.Location = new System.Drawing.Point(x + 200, y);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = "progressBar"+number;
            QueueLenght.Size = new System.Drawing.Size(120, 20);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            // labelLeave
            // 
            LeaveCustomerCount.AutoSize = true;
            LeaveCustomerCount.Location = new System.Drawing.Point(x + 350, y);
            LeaveCustomerCount.Name = "labelLeave" + number;
            LeaveCustomerCount.Size = new System.Drawing.Size(35, 13);
            LeaveCustomerCount.TabIndex = number;
            LeaveCustomerCount.Text = "";



            cashDesk.ReceiptClosed += CashDesk_ReceiptClosed;

        }

        private void CashDesk_ReceiptClosed(object sender, Receipt e)
        {
            Price.Invoke((Action)delegate { 
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                LeaveCustomerCount.Text = "Клиентов ушло: " + cashDesk.ExitCustomer.ToString();
            });          
        }
    }
}

 