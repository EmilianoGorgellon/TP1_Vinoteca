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
            dataGridViewLog.Location = new Point(200, 400);
            this.Controls.Add(dataGridViewLog);
            dataGridViewLog.Columns.Add("Columna1", "Usuario");
            dataGridViewLog.Columns.Add("Columna2", "Accion");
            dataGridViewLog.Columns.Add("Columna3", "Fecha");
            dataGridViewLog.Columns.Add("Columna4", "LogId");
            dataGridViewLog.Columns.Add("Columna5", "UserId");

            dataGridViewLog.Dock = DockStyle.Fill;

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
                    //MessageBox.Show("Se elimino satisfactoriamente");
                    FillDataToGrid();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
