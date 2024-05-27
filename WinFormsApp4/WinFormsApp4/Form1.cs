using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
            inventory.LoadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProductList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductQuantity.Text) || string.IsNullOrWhiteSpace(txtProductPrice.Text))
                {
                    txtError.Text = "Ви не ввели назву, кількість або ціну продукту.";
                    return;
                }

                string name = txtProductName.Text;
                int quantity = int.Parse(txtProductQuantity.Text);
                double price = double.Parse(txtProductPrice.Text);
                inventory.AddProduct(new Product { Name = name, Quantity = quantity, Price = price });
                RefreshProductList();
            }
            catch (FormatException)
            {
                txtError.Text = "Невірний формат введених даних.";
            }
            catch (Exception ex)
            {
                txtError.Text = "Помилка: " + ex.Message;
            }
        }


        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtOrderProductId.Text);
                int quantity = int.Parse(txtOrderQuantity.Text);
                inventory.OrderProduct(productId, quantity);
                txtOrderInfo.Text = "Продукт успішно відправлено";
                RefreshProductList();
            }
            catch (FormatException)
            {
                txtError.Text = "Ви не ввели ID та Кількість";
            }
            catch (Exception ex)
            {
                txtError.Text = "Помилка: " + ex.Message;
            }
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtSellProductId.Text);
                int quantity = int.Parse(txtSellQuantity.Text);
                double total = inventory.SellProduct(productId, quantity);
                if (total > 0)
                {
                    txtSellInfo.Text = $"Продукт успішно продано. Сума: {total}";
                }
                RefreshProductList();
            }
            catch (FormatException)
            {
                txtError.Text = "Ви не ввели ID та Кількість";
            }
            catch (Exception ex)
            {
                txtError.Text = "Помилка: " + ex.Message;
            }
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.SaveProducts();
                MessageBox.Show("Продукти збережені.");
            }
            catch (Exception ex)
            {
                txtError.Text = "Помилка: " + ex.Message;
            }
        }

        private void RefreshProductList()
        {
            lstProducts.Items.Clear();
            foreach (var product in inventory.GetProducts())
            {
                lstProducts.Items.Add(product.ToString());
            }
        }
    }
}
