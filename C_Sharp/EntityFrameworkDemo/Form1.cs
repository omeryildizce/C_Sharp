﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();

            ClearBox();

        }

        private void ClearBox()
        {
            tbxName.Clear();
            tbxNameUpdate.Clear();
            tbxStockAmount.Clear();
            tbxStockAmountUpdate.Clear();
            tbxUnitPrice.Clear();
            tbxUnitPriceUpdate.Clear();
            dgwProducts.ClearSelection();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {

            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key)).ToList();
            dgwProducts.DataSource = _productDal.GetByName(key);


            dgwProducts.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            });
            MessageBox.Show("Product added!");
            LoadProducts();
            ClearBox();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString()),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
            });
            MessageBox.Show("Product updated!");
            LoadProducts();
            ClearBox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString())
            });
            MessageBox.Show("Product deleted!");
            LoadProducts();
            ClearBox();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();


        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

            SearchProducts(tbxSearch.Text.ToLower());
            
        }
    }
}
