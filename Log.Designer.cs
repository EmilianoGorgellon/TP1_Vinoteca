namespace TP1_UTN
{
    partial class Log
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
            dataGridViewLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Location = new Point(-1, 61);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.RowTemplate.Height = 25;
            dataGridViewLog.Size = new Size(1156, 145);
            dataGridViewLog.TabIndex = 3;
            dataGridViewLog.CellClick += dataGridViewLog_CellContentClick;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1140, 503);
            ControlBox = false;
            Controls.Add(dataGridViewLog);
            Name = "Log";
            Text = "Log";
            WindowState = FormWindowState.Maximized;
            Load += Log_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPersonas;
        private DataGridView dataGridViewLog;
    }
}