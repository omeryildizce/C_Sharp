using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context1 = new NorthwindContext())
            {
                cbxCategory.DataSource = context1.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }
        private void ListProductsByProductName(string productName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

             
            }
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(key);
            }
        }
    }
}
