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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea2.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart.Legends.Add(legend2);
            chart.Location = new Point(644, 12);
            chart.Margin = new Padding(10);
            chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart.Series.Add(series2);
            chart.Size = new Size(467, 480);
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