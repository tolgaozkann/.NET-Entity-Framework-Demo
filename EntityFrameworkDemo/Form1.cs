using System;
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
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }


        private void SearchProduct(string key)
        {

            //var result = _productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txbName.Text,
                UnitPrice = Convert.ToDecimal(txbUnitPrice.Text),
                StockAmount = Convert.ToInt32(txbStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbNameUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                UnitPrice = Convert.ToDecimal(tbNameUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbStockAmountUpdate.Text),
                Name = tbNameUpdate.Text
            });

            LoadProducts();
            MessageBox.Show("Updated!!!");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted!!!!");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbSearch.Text);
        }
    }
}
