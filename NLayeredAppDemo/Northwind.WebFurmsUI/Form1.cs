using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFurmsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";


            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";


            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {


            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByCategoryName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {

                    ProductName = tbxProductNameAdd.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAdd.Text)


                });
                MessageBox.Show("Ürün Eklendi!");

                BoxClear();
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void BoxClear()
        {
            dgwProduct.ClearSelection();
            // search clear
            tbxProductName.Clear();
            // add clear
            tbxProductNameAdd.Clear();
            tbxQuantityPerUnitAdd.Clear();
            tbxStockAdd.Clear();
            tbxUnitPriceAdd.Clear();
            // update clear
            tbxUnitPriceUpdate.Clear();
            tbxProductNameUpdate.Clear();
            tbxQuantityPerUnitUpdate.Clear();
            tbxStockUpdate.Clear();
            lblProductIdUpdate.Text = ":";
            // delete clear
            lblProductIdDelete.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product()
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text
                });
                MessageBox.Show("Ürün Güncellendi!");

                BoxClear();
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            lblProductIdUpdate.Text = row.Cells[0].Value.ToString();
            lblProductIdDelete.Text = "ID : " + row.Cells[0].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = Convert.ToInt32(row.Cells[1].Value);
            tbxProductNameUpdate.Text = row.Cells[2].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           

                _productService.Delete(new Product()
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });

                MessageBox.Show("Ürün Silindi!");

                BoxClear();
                LoadProducts();



            
        }
    }
}
