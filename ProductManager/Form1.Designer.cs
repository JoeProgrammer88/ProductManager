namespace ProductManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 179);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(277, 173);
            txtProductName.Margin = new Padding(6, 6, 6, 6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(182, 39);
            txtProductName.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(74, 495);
            btnAddProduct.Margin = new Padding(6, 6, 6, 6);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(208, 139);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(323, 495);
            btnExit.Margin = new Padding(6, 6, 6, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(208, 139);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 858);
            Controls.Add(btnExit);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Product Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private Button btnExit;
    }
}
