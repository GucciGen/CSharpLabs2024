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
                    txtError.Text = "�� �� ����� �����, ������� ��� ���� ��������.";
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
                txtError.Text = "������� ������ �������� �����.";
            }
            catch (Exception ex)
            {
                txtError.Text = "�������: " + ex.Message;
            }
        }


        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtOrderProductId.Text);
                int quantity = int.Parse(txtOrderQuantity.Text);
                inventory.OrderProduct(productId, quantity);
                txtOrderInfo.Text = "������� ������ ����������";
                RefreshProductList();
            }
            catch (FormatException)
            {
                txtError.Text = "�� �� ����� ID �� ʳ������";
            }
            catch (Exception ex)
            {
                txtError.Text = "�������: " + ex.Message;
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
                    txtSellInfo.Text = $"������� ������ �������. ����: {total}";
                }
                RefreshProductList();
            }
            catch (FormatException)
            {
                txtError.Text = "�� �� ����� ID �� ʳ������";
            }
            catch (Exception ex)
            {
                txtError.Text = "�������: " + ex.Message;
            }
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.SaveProducts();
                MessageBox.Show("�������� ��������.");
            }
            catch (Exception ex)
            {
                txtError.Text = "�������: " + ex.Message;
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
