namespace TP1_UTN
{
    partial class ProductoBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBox));
            lbl_fecha = new Label();
            btn_add_carrito = new Button();
            lbl_price = new Label();
            lbl_title = new Label();
            pbox_image = new PictureBox();
            lbl_stock = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox_image).BeginInit();
            SuspendLayout();
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha.Location = new Point(32, 334);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(44, 19);
            lbl_fecha.TabIndex = 9;
            lbl_fecha.Text = "Fecha";
            // 
            // btn_add_carrito
            // 
            btn_add_carrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_carrito.Location = new Point(12, 366);
            btn_add_carrito.Name = "btn_add_carrito";
            btn_add_carrito.Size = new Size(196, 35);
            btn_add_carrito.TabIndex = 8;
            btn_add_carrito.Text = "Agregar al carrito";
            btn_add_carrito.UseVisualStyleBackColor = true;
            btn_add_carrito.Click += btn_add_carrito_Click;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_price.Location = new Point(32, 292);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(53, 21);
            lbl_price.TabIndex = 7;
            lbl_price.Text = "Precio";
            lbl_price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(32, 260);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(75, 32);
            lbl_title.TabIndex = 6;
            lbl_title.Text = "Titulo";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbox_image
            // 
            pbox_image.Image = (Image)resources.GetObject("pbox_image.Image");
            pbox_image.Location = new Point(12, 12);
            pbox_image.Name = "pbox_image";
            pbox_image.Size = new Size(196, 235);
            pbox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_image.TabIndex = 5;
            pbox_image.TabStop = false;
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stock.Location = new Point(32, 313);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(47, 21);
            lbl_stock.TabIndex = 10;
            lbl_stock.Text = "Stock";
            // 
            // ProductoBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(lbl_stock);
            Controls.Add(lbl_fecha);
            Controls.Add(btn_add_carrito);
            Controls.Add(lbl_price);
            Controls.Add(lbl_title);
            Controls.Add(pbox_image);
            Margin = new Padding(20);
            Name = "ProductoBox";
            Padding = new Padding(20);
            Size = new Size(229, 424);
            ((System.ComponentModel.ISupportInitialize)pbox_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_fecha;
        private Button btn_add_carrito;
        private Label lbl_price;
        private Label lbl_title;
        private PictureBox pbox_image;
        private Label lbl_stock;
    }
}