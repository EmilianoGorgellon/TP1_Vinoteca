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

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string user = txtbox_user.Text;
            string pw = txb_password.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pw))
            {
                //var cliente = new Cliente(user, pw, 0);
                FirebaseResponse response = await Firebase.GetAsync("users");
                Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

                foreach (KeyValuePair<string, Cliente> elemento in lista)
                {
                    if (elemento.Value.Usuario == user && elemento.Value.Password == pw)
                    {
                        this.Hide();
                        Admin admin = new();
                        _ = elemento.Value.IsAdmin == true ? admin.isAdmin = true : admin.isAdmin = false;
                     
                        admin.Show();

                    }
                    lbl_credentialsError.Text = "Error, credenciales invalidas";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar usuario y/o contraseña");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Registrarse register = new();
            register.isAdmin = false;
            register.Show();
        }
    }


}