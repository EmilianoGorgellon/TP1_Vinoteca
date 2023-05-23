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
    public partial class listaClientes : Form
    {
        public listaClientes()
        {
            InitializeComponent();
        }


        private async void listaClientes_Load(object sender, EventArgs e)
        {
            dataGridViewPersonas.Location = new Point(200, 400);
            this.Controls.Add(dataGridViewPersonas);
            dataGridViewPersonas.Columns.Add("Columna1", "Usuario");
            dataGridViewPersonas.Columns.Add("Columna2", "Password");
            dataGridViewPersonas.Columns.Add("Columna3", "Puntos");
            dataGridViewPersonas.Columns.Add("Columna4", "Rol");
            dataGridViewPersonas.Columns.Add("Columna5", "Id");

            dataGridViewPersonas.Dock = DockStyle.Fill;

            // agrego boton editar
            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.HeaderText = "Editar";
            editar.Text = "Editar";
            editar.Name = "btn_edit";
            editar.FlatStyle = FlatStyle.Flat;
            editar.UseColumnTextForButtonValue = true;
            editar.CellTemplate.Style.BackColor = Color.Green;
            editar.CellTemplate.Style.ForeColor = Color.White;
            dataGridViewPersonas.Columns.Add(editar);

            // agrego boton eliminar
            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();

            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.Name = "btn_delete";
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.CellTemplate.Style.BackColor = Color.Red;
            eliminar.CellTemplate.Style.ForeColor = Color.White;
            dataGridViewPersonas.Columns.Add(eliminar);
            FillDataToGrid();
        }

        private async void FillDataToGrid()
        {

            dataGridViewPersonas.Rows.Clear();
            FirebaseResponse response = await Firebase.GetAsync("users");
            Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

            foreach (KeyValuePair<string, Cliente> elemento in lista)
            {
                object[] row = { elemento.Value.Usuario, elemento.Value.Password, elemento.Value.Puntos, elemento.Value.IsAdmin == true ? "Administrador" : "Cliente", elemento.Key };
                dataGridViewPersonas.Rows.Add(row);

            }


        }

        private async void dataGridViewPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Administrador admin = new Administrador();
            if (dataGridViewPersonas.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                string rol = (string)dataGridViewPersonas.Rows[e.RowIndex].Cells[3].Value;
                string id = (string)dataGridViewPersonas.Rows[e.RowIndex].Cells[4].Value;
                MessageBox.Show(await admin.deleteClientUser(id, rol));
                FillDataToGrid();

            }
            else if (dataGridViewPersonas.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                MessageBox.Show("Lo tengo que Editar: " + e.RowIndex);

                string user = (string)dataGridViewPersonas.Rows[e.RowIndex].Cells[0].Value;
                string password = (string)dataGridViewPersonas.Rows[e.RowIndex].Cells[1].Value;
                int puntos = (int)dataGridViewPersonas.Rows[e.RowIndex].Cells[2].Value;
                string id = (string)dataGridViewPersonas.Rows[e.RowIndex].Cells[4].Value;
                EditUser edicionUser = new EditUser();

                edicionUser.cargarFormulario(user, password, puntos, id);
                edicionUser.Show();
                FillDataToGrid();
            }
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            Registrarse register = new Registrarse();
            register.isAdmin = true;
            register.Show();
        }

    }
}
