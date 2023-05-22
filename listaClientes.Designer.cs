namespace TP1_UTN
{
    partial class listaClientes
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
            dataGridViewPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersonas
            // 
            dataGridViewPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersonas.BorderStyle = BorderStyle.None;
            dataGridViewPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonas.Location = new Point(3, 104);
            dataGridViewPersonas.Name = "dataGridViewPersonas";
            dataGridViewPersonas.RowTemplate.Height = 25;
            dataGridViewPersonas.Size = new Size(1156, 145);
            dataGridViewPersonas.TabIndex = 1;
            dataGridViewPersonas.CellContentClick += dataGridViewPersonas_CellContentClick;
            // 
            // listaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 542);
            Controls.Add(dataGridViewPersonas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaClientes";
            ShowIcon = false;
            Text = "listaClientes";
            WindowState = FormWindowState.Maximized;
            Load += listaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPersonas;
    }
}