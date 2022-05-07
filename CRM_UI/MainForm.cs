using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_BL;
using CRM_BL.Model;

namespace CRM_UI
{
    public partial class Form1 : Form
    {

        CRMContext db;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;

        public Form1()
        {
            InitializeComponent();
            db = new CRMContext();

            customer = new Customer();
            cart = new Cart(customer);
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Task.Run(() => 
            {
                listBox1.Invoke((Action)delegate 
                {
                    listBox1.Items.AddRange(db.Products.ToArray());
                    listBox2.Items.AddRange(cart.GetAll().ToArray());

                });
            });
        }   



        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void ReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogReceipt = new Catalog<Receipt>(db.Receipts, db);
            catalogReceipt.Show();
        }

        private void AddCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            var form = new AddCustomer();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }



        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddProduct();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void AddSellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new AddSeller();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void modelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product product) 
            {
                cart.Add(product);
                listBox2.Items.Add(product);
                label1.Text = "Итого: " + cart.Price;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (customer.Name == null)
            {
                var form = new Login();
                form.ShowDialog();

                var user = db.Customers.FirstOrDefault(x => x.Name.Equals(form.UserName));

                if (user != null)
                {
                    customer = user;
                }
                else
                {
                    customer = new Customer()
                    {
                        Name = form.UserName,
                    };

                    db.Customers.Add(customer);
                    db.SaveChanges();
                }

                linkLabel1.Text = $"Здравствуй, {customer}";

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customer.Name != null && cart.Price > 0)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                listBox2.Items.Clear();
                cart = new Cart(customer);
                label1.Text = "Итого: ";

                MessageBox.Show("Покупка выполнена, сумма: " + price, "Покупка выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (customer.Name == null)
            {
                MessageBox.Show("Авторизуйтесь!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cart.Price == 0)
            {
                MessageBox.Show("Корзина пуста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

    }
}
