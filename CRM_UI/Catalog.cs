﻿using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        CRMContext db;
        DbSet<T> set;

        public Catalog(DbSet<T> set, CRMContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (typeof(T) == typeof(Product))
            {

            }

            else if (typeof(T) == typeof(Seller))
            {

            }

            else if ( typeof(T) == typeof(Customer))
            {

            }






        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            // Получаем Id выделенного объекта

            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;
                if (product != null)
                {
                    var form = new AddProduct(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }
            }

            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var form = new AddSeller(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.Seller;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }
            }

            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;
                if (customer != null)
                {
                    var form = new AddCustomer(customer);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        customer = form.Customer;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }
            }




        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}
