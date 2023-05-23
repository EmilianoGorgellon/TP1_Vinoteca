namespace TP1_UTN
{
    partial class EditUser
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
            numeric_puntos = new NumericUpDown();
            lbl_puntos = new Label();
            btn_update = new Button();
            txtbox_user = new TextBox();
            label1 = new Label();
            txb_password = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numeric_puntos).BeginInit();
            SuspendLayout();
            // 
            // numeric_puntos
            // 
            numeric_puntos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_puntos.Location = new Point(12, 154);
            numeric_puntos.Name = "numeric_puntos";
            numeric_puntos.Size = new Size(150, 27);
            numeric_puntos.TabIndex = 26;
            // 
            // lbl_puntos
            // 
            lbl_puntos.AutoSize = true;
            lbl_puntos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_puntos.Location = new Point(12, 131);
            lbl_puntos.Name = "lbl_puntos";
            lbl_puntos.Size = new Size(53, 20);
            lbl_puntos.TabIndex = 25;
            lbl_puntos.Text = "Puntos";
            lbl_puntos.Visible = false;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(12, 195);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 33);
            btn_update.TabIndex = 24;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txtbox_user
            // 
            txtbox_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_user.Location = new Point(12, 33);
            txtbox_user.Name = "txtbox_user";
            txtbox_user.Size = new Size(150, 27);
            txtbox_user.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 20;
            label1.Text = "Usuario";
            // 
            // txb_password
            // 
            txb_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_password.Location = new Point(12, 92);
            txb_password.Name = "txb_password";
            txb_password.PasswordChar = '*';
            txb_password.PlaceholderText = "Ingrese su contraseña";
            txb_password.Size = new Size(150, 27);
            txb_password.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 27;
            label2.Text = "Contraseña";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 255);
            Controls.Add(txb_password);
            Controls.Add(label2);
            Controls.Add(numeric_puntos);
            Controls.Add(lbl_puntos);
            Controls.Add(btn_update);
            Controls.Add(txtbox_user);
            Controls.Add(label1);
            Name = "EditUser";
            Text = "EditUser";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_puntos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numeric_puntos;
        private Label lbl_puntos;
        private Button btn_update;
        private TextBox txtbox_user;
        private Label label1;
        private TextBox txb_password;
        private Label label2;
    }
}