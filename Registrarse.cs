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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        public bool isAdmin { get; set; }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                numeric_puntos.Show();
                lbl_puntos.Show();
            }
        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            string user = txtbox_user.Text;
            string pw = txb_password.Text;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pw) && int.TryParse(numeric_puntos.Text, out int puntos))
            {
                Cliente client = new Cliente(user, pw, puntos);

                FirebaseResponse response = await Firebase.SetAsyncClient(client);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se creo satisfactoriamente el usuario");
                }

                this.Hide();
            }
        }


    }
}
