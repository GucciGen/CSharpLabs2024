namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddProduct;
        private Button btnOrderProduct;
        private Button btnSellProduct;
        private Button btnSaveProducts;
        private TextBox txtProductName;
        private TextBox txtProductQuantity;
        private TextBox txtProductPrice;
        private TextBox txtOrderProductId;
        private TextBox txtOrderQuantity;
        private TextBox txtSellProductId;
        private TextBox txtSellQuantity;
        private ListBox lstProducts;
        private TextBox txtError;
        private TextBox txtOrderInfo;
        private TextBox txtSellInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddProduct = new Button();
            this.btnOrderProduct = new Button();
            this.btnSellProduct = new Button();
            this.btnSaveProducts = new Button();
            this.txtProductName = new TextBox();
            this.txtProductQuantity = new TextBox();
            this.txtProductPrice = new TextBox();
            this.txtOrderProductId = new TextBox();
            this.txtOrderQuantity = new TextBox();
            this.txtSellProductId = new TextBox();
            this.txtSellQuantity = new TextBox();
            this.lstProducts = new ListBox();
            this.txtError = new TextBox();
            this.txtOrderInfo = new TextBox();
            this.txtSellInfo = new TextBox();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnOrderProduct);
            this.Controls.Add(this.btnSellProduct);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtOrderProductId);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.txtSellProductId);
            this.Controls.Add(this.txtSellQuantity);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtOrderInfo);
            this.Controls.Add(this.txtSellInfo);
            this.Name = "Form1";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(50, 150);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Location = new System.Drawing.Point(200, 150);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Size = new System.Drawing.Size(100, 30);
            this.btnOrderProduct.Text = "Order Product";
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);

            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Location = new System.Drawing.Point(350, 150);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(100, 30);
            this.btnSellProduct.Text = "Sell Product";
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(500, 150);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(100, 30);
            this.btnSaveProducts.Text = "Save Products";
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(50, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Product Name";
            this.txtProductName.Size = new System.Drawing.Size(150, 27);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(220, 50);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PlaceholderText = "Quantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 27);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(340, 50);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PlaceholderText = "Price";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 27);
            // 
            // txtOrderProductId
            // 
            this.txtOrderProductId.Location = new System.Drawing.Point(50, 200);
            this.txtOrderProductId.Name = "txtOrderProductId";
            this.txtOrderProductId.PlaceholderText = "Order Product ID";
            this.txtOrderProductId.Size = new System.Drawing.Size(150, 50);
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(220, 200);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.PlaceholderText = "Quantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(150, 50);
            // 
            // txtSellProductId
            // 
            this.txtSellProductId.Location = new System.Drawing.Point(50, 250);
            this.txtSellProductId.Name = "txtSellProductId";
            this.txtSellProductId.PlaceholderText = "Sell Product ID";
            this.txtSellProductId.Size = new System.Drawing.Size(150, 50);
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Location = new System.Drawing.Point(220, 250);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.PlaceholderText = "Quantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(150, 50);
            // 
            // lstProducts
            // 
            this.lstProducts.Location = new System.Drawing.Point(50, 300);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(700, 200);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(50, 520);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(700, 27);
            // 
            // txtOrderInfo
            // 
            this.txtOrderInfo.Location = new System.Drawing.Point(50, 570);
            this.txtOrderInfo.Name = "txtOrderInfo";
            this.txtOrderInfo.ReadOnly = true;
            this.txtOrderInfo.Size = new System.Drawing.Size(700, 27);
            // 
            // txtSellInfo
            // 
            this.txtSellInfo.Location = new System.Drawing.Point(50, 620);
            this.txtSellInfo.Name = "txtSellInfo";
            this.txtSellInfo.ReadOnly = true;
            this.txtSellInfo.Size = new System.Drawing.Size(700, 27);
        }
    }
}
