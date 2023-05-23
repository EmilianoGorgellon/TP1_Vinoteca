namespace TP1_UTN
{
    partial class Carrito
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
            label1 = new Label();
            flpanel_carrito = new FlowLayoutPanel();
            btn_comprar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-3, 18);
            label1.Name = "label1";
            label1.Size = new Size(1143, 49);
            label1.TabIndex = 0;
            label1.Text = "Carrito de compras";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpanel_carrito
            // 
            flpanel_carrito.AutoScroll = true;
            flpanel_carrito.Location = new Point(12, 109);
            flpanel_carrito.Name = "flpanel_carrito";
            flpanel_carrito.Size = new Size(1116, 312);
            flpanel_carrito.TabIndex = 1;
            // 
            // btn_comprar
            // 
            btn_comprar.BackColor = Color.DodgerBlue;
            btn_comprar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_comprar.ForeColor = Color.White;
            btn_comprar.Location = new Point(932, 440);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(196, 41);
            btn_comprar.TabIndex = 2;
            btn_comprar.Text = "Comprar";
            btn_comprar.UseVisualStyleBackColor = false;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 503);
            Controls.Add(btn_comprar);
            Controls.Add(flpanel_carrito);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carrito";
            Text = "Carrito";
            Load += Carrito_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpanel_carrito;
        private Button btn_comprar;
    }
}