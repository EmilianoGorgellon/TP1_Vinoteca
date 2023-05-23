namespace TP1_UTN
{
    partial class EditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbox_image = new PictureBox();
            btn_select_image = new Button();
            numeric_stock = new NumericUpDown();
            btn_update_product = new Button();
            lbl_stock = new Label();
            numeric_price = new NumericUpDown();
            lbl_precio = new Label();
            txb_name = new TextBox();
            lbl_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_price).BeginInit();
            SuspendLayout();
            // 
            // pbox_image
            // 
            pbox_image.Location = new Point(87, 216);
            pbox_image.Name = "pbox_image";
            pbox_image.Size = new Size(96, 80);
            pbox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_image.TabIndex = 18;
            pbox_image.TabStop = false;
            // 
            // btn_select_image
            // 
            btn_select_image.BackColor = Color.White;
            btn_select_image.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_select_image.Location = new Point(18, 302);
            btn_select_image.Name = "btn_select_image";
            btn_select_image.Size = new Size(226, 30);
            btn_select_image.TabIndex = 17;
            btn_select_image.Text = "Seleccionar imagen";
            btn_select_image.UseVisualStyleBackColor = false;
            btn_select_image.Click += btn_select_image_Click;
            // 
            // numeric_stock
            // 
            numeric_stock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_stock.Location = new Point(18, 175);
            numeric_stock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numeric_stock.Name = "numeric_stock";
            numeric_stock.Size = new Size(226, 27);
            numeric_stock.TabIndex = 16;
            // 
            // btn_update_product
            // 
            btn_update_product.BackColor = Color.White;
            btn_update_product.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update_product.Location = new Point(18, 352);
            btn_update_product.Name = "btn_update_product";
            btn_update_product.Size = new Size(226, 33);
            btn_update_product.TabIndex = 15;
            btn_update_product.Text = "Actualizar producto";
            btn_update_product.UseVisualStyleBackColor = false;
            btn_update_product.Click += btn_update_product_Click;
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stock.ForeColor = Color.White;
            lbl_stock.Location = new Point(18, 152);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(135, 20);
            lbl_stock.TabIndex = 14;
            lbl_stock.Text = "Stock del producto";
            // 
            // numeric_price
            // 
            numeric_price.DecimalPlaces = 2;
            numeric_price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_price.Location = new Point(18, 106);
            numeric_price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numeric_price.Name = "numeric_price";
            numeric_price.Size = new Size(226, 27);
            numeric_price.TabIndex = 13;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_precio.ForeColor = Color.White;
            lbl_precio.Location = new Point(18, 83);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(140, 20);
            lbl_precio.TabIndex = 12;
            lbl_precio.Text = "Precio del producto";
            // 
            // txb_name
            // 
            txb_name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_name.Location = new Point(18, 42);
            txb_name.Name = "txb_name";
            txb_name.PlaceholderText = "Nombre";
            txb_name.Size = new Size(226, 27);
            txb_name.TabIndex = 11;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(18, 19);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(154, 20);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Nombre del producto";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(264, 399);
            Controls.Add(pbox_image);
            Controls.Add(btn_select_image);
            Controls.Add(numeric_stock);
            Controls.Add(btn_update_product);
            Controls.Add(lbl_stock);
            Controls.Add(numeric_price);
            Controls.Add(lbl_precio);
            Controls.Add(txb_name);
            Controls.Add(lbl_name);
            Name = "EditProduct";
            Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)pbox_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbox_image;
        private Button btn_select_image;
        private NumericUpDown numeric_stock;
        private Label lbl_stock;
        private NumericUpDown numeric_price;
        private Label lbl_precio;
        private TextBox txb_name;
        private Label lbl_name;
        private Button btn_update_product;
    }
}