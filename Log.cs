using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            this.Controls.Add(dataGridViewLog);
            dataGridViewLog.Columns.Add("Columna1", "Usuario");
            dataGridViewLog.Columns.Add("Columna2", "Accion");
            dataGridViewLog.Columns.Add("Columna3", "Fecha");
            dataGridViewLog.Columns.Add("Columna4", "LogId");
            dataGridViewLog.Columns.Add("Columna5", "UserId");

            // agrego boton eliminar
            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.Name = "btn_delete";
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.CellTemplate.Style.BackColor = Color.Red;
            eliminar.CellTemplate.Style.ForeColor = Color.White;
            dataGridViewLog.Columns.Add(eliminar);


            FillDataToGrid();
            FillDataToChart();
        }
        private async void FillDataToGrid()
        {

            dataGridViewLog.Rows.Clear();
            FirebaseResponse response = await Firebase.GetElement("logs");
            Dictionary<string, Logs> lista = JsonConvert.DeserializeObject<Dictionary<string, Logs>>(response.Body);

            foreach (KeyValuePair<string, Logs> elemento in lista)
            {
                string user = await Logs.GetUser(elemento.Value.IdUser);
                object[] row = { user, elemento.Value.Action, elemento.Value.FechaActual, elemento.Key, elemento.Value.IdUser };
                dataGridViewLog.Rows.Add(row);
            }
        }

        private async void FillDataToChart()
        {
            FirebaseResponse response = await Firebase.GetElement("productos");
            Dictionary<string, Logs> lista = JsonConvert.DeserializeObject<Dictionary<string, Logs>>(response.Body);

            //string[] series = { "Primero", "segundo", "tercero" };
            //int[] puntos = { 23, 70, 10 };

            //chart.Titles.Add("Tituloo");

            //for (int i = 0; i < series.Length; i++)
            //{
            //    Series serie = chart.Series.Add(series[i]);

            //    serie.Label = puntos[i].ToString();
            //    serie.Points.Add(puntos[i]);
            //}
            
            foreach (KeyValuePair<string, Logs> elemento in lista)
            {
                string user = await Logs.GetUser(elemento.Value.IdUser);
                Series serie = chart.Series.Add(user);
                serie.Label = elemento.Value.Action;
                //serie.Label = elemento.Value.
                //serie.Points.Add(puntos[i]);

            }
        }

        /// <summary>
        /// Obtengo el click del usuario en la celda seleccionada, si es eliminar elimino y si edita edito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dataGridViewLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewLog.Columns[e.ColumnIndex].Name == "btn_delete")
                {
                    string id = (string)dataGridViewLog.Rows[e.RowIndex].Cells[3].Value;
                    Logs.DeleteLogs($"logs/{id}");
                    FillDataToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
