using FireSharp;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Inicia sesion y dependiendo si es cliente o administrador va a tener distintos permisos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_login_Click(object sender, EventArgs e)
        {
            string user = txtbox_user.Text;
            string pw = txb_password.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pw))
            {
                FirebaseResponse response = await Firebase.GetAsync("users");
                Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

                foreach (KeyValuePair<string, Cliente> elemento in lista)
                {
                    if (elemento.Value.Usuario == user && elemento.Value.Password == pw)
                    {
                        this.Hide();
                        Admin admin = new();
                        _ = elemento.Value.IsAdmin == true ? admin._isAdmin = true : admin._isAdmin = false;
                        admin.ShowDialog();
                        if (admin.DialogResult == DialogResult.Cancel)
                        {
                            this.Show();
                        }

                    }
                    lbl_credentialsError.Text = "Error, credenciales invalidas";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar usuario y/o contraseņa");
            }
        }
        /// <summary>
        /// Registra un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            Registrarse register = new();
            register.isAdmin = false;
            register.Show();
        }
        /// <summary>
        /// Boton para ingresar desde admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_test_admin_Click(object sender, EventArgs e)
        {
            txtbox_user.Text = "admin";
            txb_password.Text = "admin";
        }
        /// <summary>
        /// Boton para ingresar desde cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            txtbox_user.Text = "nuevo";
            txb_password.Text = "nuevo";
        }
    }


}