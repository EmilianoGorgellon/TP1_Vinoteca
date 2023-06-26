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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            dataGridViewLog = new DataGridView();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLog.BackgroundColor = Color.DeepSkyBlue;
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Location = new Point(1, 1);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.ReadOnly = true;
            dataGridViewLog.RowTemplate.Height = 25;
            dataGridViewLog.Size = new Size(637, 503);
            dataGridViewLog.TabIndex = 3;
            dataGridViewLog.CellClick += dataGridViewLog_CellContentClick;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(651, 1);
            chart.Margin = new Padding(10);
            chart.Name = "chart";
            chart.Size = new Size(467, 609);
            chart.TabIndex = 4;
            chart.Text = "Grafico de logs";
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1140, 503);
            ControlBox = false;
            Controls.Add(chart);
            Controls.Add(dataGridViewLog);
            Name = "Log";
            Text = "Log";
            WindowState = FormWindowState.Maximized;
            Load += Log_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPersonas;
        private DataGridView dataGridViewLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}