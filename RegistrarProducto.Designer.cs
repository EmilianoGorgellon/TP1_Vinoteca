namespace TP1_UTN
{
    partial class RegistrarProducto
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
            lbl_name = new Label();
            txb_name = new TextBox();
            lbl_precio = new Label();
            numeric_price = new NumericUpDown();
            lbl_stock = new Label();
            btn_add_product = new Button();
            numeric_stock = new NumericUpDown();
            btn_select_image = new Button();
            pbox_image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numeric_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_image).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(12, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(154, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Nombre del producto";
            // 
            // txb_name
            // 
            txb_name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_name.Location = new Point(12, 32);
            txb_name.Name = "txb_name";
            txb_name.PlaceholderText = "Nombre";
            txb_name.Size = new Size(226, 27);
            txb_name.TabIndex = 1;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_precio.ForeColor = Color.White;
            lbl_precio.Location = new Point(12, 73);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(140, 20);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio del producto";
            // 
            // numeric_price
            // 
            numeric_price.DecimalPlaces = 2;
            numeric_price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_price.Location = new Point(12, 96);
            numeric_price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numeric_price.Name = "numeric_price";
            numeric_price.Size = new Size(226, 27);
            numeric_price.TabIndex = 3;
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stock.ForeColor = Color.White;
            lbl_stock.Location = new Point(12, 142);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(135, 20);
            lbl_stock.TabIndex = 4;
            lbl_stock.Text = "Stock del producto";
            // 
            // btn_add_product
            // 
            btn_add_product.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_product.Location = new Point(12, 342);
            btn_add_product.Name = "btn_add_product";
            btn_add_product.Size = new Size(226, 33);
            btn_add_product.TabIndex = 6;
            btn_add_product.Text = "Agregar producto";
            btn_add_product.UseVisualStyleBackColor = true;
            btn_add_product.Click += btn_add_product_Click;
            // 
            // numeric_stock
            // 
            numeric_stock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_stock.Location = new Point(12, 165);
            numeric_stock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numeric_stock.Name = "numeric_stock";
            numeric_stock.Size = new Size(226, 27);
            numeric_stock.TabIndex = 7;
            // 
            // btn_select_image
            // 
            btn_select_image.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_select_image.Location = new Point(12, 292);
            btn_select_image.Name = "btn_select_image";
            btn_select_image.Size = new Size(226, 30);
            btn_select_image.TabIndex = 8;
            btn_select_image.Text = "Seleccionar imagen";
            btn_select_image.UseVisualStyleBackColor = true;
            btn_select_image.Click += btn_select_image_Click;
            // 
            // pbox_image
            // 
            pbox_image.Location = new Point(81, 206);
            pbox_image.Name = "pbox_image";
            pbox_image.Size = new Size(96, 80);
            pbox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_image.TabIndex = 9;
            pbox_image.TabStop = false;
            // 
            // RegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(252, 387);
            Controls.Add(pbox_image);
            Controls.Add(btn_select_image);
            Controls.Add(numeric_stock);
            Controls.Add(btn_add_product);
            Controls.Add(lbl_stock);
            Controls.Add(numeric_price);
            Controls.Add(lbl_precio);
            Controls.Add(txb_name);
            Controls.Add(lbl_name);
            Name = "RegistrarProducto";
            Text = "RegistrarProducto";
            ((System.ComponentModel.ISupportInitialize)numeric_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private TextBox txb_name;
        private Label lbl_precio;
        private NumericUpDown numeric_price;
        private Label lbl_stock;
        private Button btn_add_product;
        private NumericUpDown numeric_stock;
        private Label lbl_image;
        private PictureBox pictureBox1;
        private Button btn_select_image;
        private PictureBox pbox_image;
    }
}