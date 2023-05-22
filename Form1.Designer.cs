namespace TP1_UTN
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
            btn_login = new Button();
            btn_register = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            txtbox_user = new TextBox();
            pictureBox1 = new PictureBox();
            lbl_credentialsError = new Label();
            txb_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(453, 362);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(115, 35);
            btn_login.TabIndex = 0;
            btn_login.Text = "Iniciar sesion";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(252, 362);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(115, 35);
            btn_register.TabIndex = 1;
            btn_register.Text = "Registrarse";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 195);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 266);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtbox_user
            // 
            txtbox_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_user.Location = new Point(335, 218);
            txtbox_user.Name = "txtbox_user";
            txtbox_user.PlaceholderText = "Ingrese su usuario";
            txtbox_user.Size = new Size(150, 27);
            txtbox_user.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(345, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbl_credentialsError
            // 
            lbl_credentialsError.AutoSize = true;
            lbl_credentialsError.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_credentialsError.ForeColor = Color.Red;
            lbl_credentialsError.Location = new Point(317, 329);
            lbl_credentialsError.Name = "lbl_credentialsError";
            lbl_credentialsError.Size = new Size(0, 20);
            lbl_credentialsError.TabIndex = 7;
            // 
            // txb_password
            // 
            txb_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_password.Location = new Point(335, 289);
            txb_password.Name = "txb_password";
            txb_password.PasswordChar = '*';
            txb_password.PlaceholderText = "Ingrese su contraseña";
            txb_password.Size = new Size(150, 27);
            txb_password.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_password);
            Controls.Add(lbl_credentialsError);
            Controls.Add(txtbox_user);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_register;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox txtbox_user;
        private PictureBox pictureBox1;
        private Label lbl_credentialsError;
        private TextBox txb_password;
    }
}