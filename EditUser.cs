using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }
        private string _id;

        public string Id { get { return _id; } set { _id = value; } }
        /// <summary>
        /// Cargo el formulario con los valores que recibo por parametro
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="password">Contraseña</param>
        /// <param name="puntos">Son los puntos del cliente</param>
        /// <param name="id">El id del usuario</param>
        public void cargarFormulario(string nombre, string password, int puntos, string id)
        {
            txtbox_user.Text = nombre;
            txb_password.Text = password;
            numeric_puntos.Text = puntos.ToString();
            Id = id;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Actualizo al usuario con todos los valores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_user.Text) && !string.IsNullOrEmpty(txb_password.Text) && int.TryParse(numeric_puntos.Text, out int puntos))
            {
                Cliente client = new Cliente(txtbox_user.Text, txb_password.Text, puntos);
                FirebaseResponse response = await Firebase.UpdateClient(_id, client);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se actualizo el cliente");
                }
                else
                {
                    MessageBox.Show($"Error: ${response}");
                }
                this.Close();
            }
        }
    }
}
