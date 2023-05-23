namespace TP1_UTN
{
    partial class Registrarse
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
            txb_password = new TextBox();
            txtbox_user = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_save = new Button();
            lbl_puntos = new Label();
            numeric_puntos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numeric_puntos).BeginInit();
            SuspendLayout();
            // 
            // txb_password
            // 
            txb_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_password.Location = new Point(12, 102);
            txb_password.Name = "txb_password";
            txb_password.PasswordChar = '*';
            txb_password.PlaceholderText = "Ingrese su contraseña";
            txb_password.Size = new Size(150, 27);
            txb_password.TabIndex = 13;
            // 
            // txtbox_user
            // 
            txtbox_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_user.Location = new Point(12, 40);
            txtbox_user.Name = "txtbox_user";
            txtbox_user.PlaceholderText = "Ingrese su usuario";
            txtbox_user.Size = new Size(150, 27);
            txtbox_user.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "Usuario";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.Location = new Point(12, 213);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(150, 33);
            btn_save.TabIndex = 14;
            btn_save.Text = "Crear cliente";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_puntos
            // 
            lbl_puntos.AutoSize = true;
            lbl_puntos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_puntos.ForeColor = Color.White;
            lbl_puntos.Location = new Point(12, 136);
            lbl_puntos.Name = "lbl_puntos";
            lbl_puntos.Size = new Size(53, 20);
            lbl_puntos.TabIndex = 18;
            lbl_puntos.Text = "Puntos";
            lbl_puntos.Visible = false;
            // 
            // numeric_puntos
            // 
            numeric_puntos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_puntos.Location = new Point(12, 159);
            numeric_puntos.Name = "numeric_puntos";
            numeric_puntos.Size = new Size(150, 27);
            numeric_puntos.TabIndex = 19;
            numeric_puntos.Visible = false;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(182, 266);
            Controls.Add(numeric_puntos);
            Controls.Add(lbl_puntos);
            Controls.Add(btn_save);
            Controls.Add(txb_password);
            Controls.Add(txtbox_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrarse";
            Text = "Registrarse";
            Load += Registrarse_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_puntos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_password;
        private TextBox txtbox_user;
        private Label label2;
        private Label label1;
        private Button btn_save;
        private Label lbl_puntos;
        private NumericUpDown numeric_puntos;
    }
}