namespace TP1_UTN
{
    partial class Productos
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
            lbl_product_title = new Label();
            flpanel_productos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lbl_product_title
            // 
            lbl_product_title.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_product_title.ForeColor = Color.White;
            lbl_product_title.Location = new Point(0, 14);
            lbl_product_title.Name = "lbl_product_title";
            lbl_product_title.Size = new Size(1158, 76);
            lbl_product_title.TabIndex = 0;
            lbl_product_title.Text = "Productos";
            lbl_product_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpanel_productos
            // 
            flpanel_productos.AutoScroll = true;
            flpanel_productos.Location = new Point(0, 114);
            flpanel_productos.Name = "flpanel_productos";
            flpanel_productos.Size = new Size(1158, 429);
            flpanel_productos.TabIndex = 2;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1156, 542);
            Controls.Add(flpanel_productos);
            Controls.Add(lbl_product_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_product_title;
        private FlowLayoutPanel flpanel_productos;
    }
}