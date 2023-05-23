namespace TP1_UTN
{
    partial class CarritoBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbox_image = new PictureBox();
            lbl_title = new Label();
            lbl_price = new Label();
            lbl_cantidad = new Label();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbox_image).BeginInit();
            SuspendLayout();
            // 
            // pbox_image
            // 
            pbox_image.Location = new Point(9, 0);
            pbox_image.Name = "pbox_image";
            pbox_image.Size = new Size(189, 180);
            pbox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_image.TabIndex = 0;
            pbox_image.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(195, 36);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(187, 118);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "Titulo";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            lbl_price.BackColor = Color.White;
            lbl_price.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_price.Location = new Point(388, 36);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(202, 118);
            lbl_price.TabIndex = 2;
            lbl_price.Text = "Precio";
            lbl_price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.BackColor = Color.White;
            lbl_cantidad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cantidad.Location = new Point(596, 36);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(211, 118);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "Cantidad";
            lbl_cantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(813, 72);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(209, 47);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // CarritoBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_price);
            Controls.Add(btn_eliminar);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_title);
            Controls.Add(pbox_image);
            Name = "CarritoBox";
            Size = new Size(1051, 180);
            ((System.ComponentModel.ISupportInitialize)pbox_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbox_image;
        private Label lbl_title;
        private Label lbl_price;
        private Label label2;
        private Label label3;
        private Button btn_eliminar;
        private Label lbl_cantidad;
    }
}
