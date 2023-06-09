﻿using FireSharp.Response;
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
        public delegate bool ConfirmacionCierreDelegate();
        public bool isAdmin { get; set; }


        private ConfirmacionCierreDelegate confirmacionCierreHandler;

        public ConfirmacionCierreDelegate ConfirmacionCierreHandler
        {
            get { return confirmacionCierreHandler; }
            set { confirmacionCierreHandler = value; }
        }


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
            try
            {
                string user = txtbox_user.Text;
                string pw = txb_password.Text;
                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pw) && int.TryParse(numeric_puntos.Text, out int puntos))
                {
                    MessageBox.Show(await Cliente.CreateUser(user, pw, puntos));
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ConfirmacionCierreHandler != null)
            {
                bool confirmacion = ConfirmacionCierreHandler.Invoke();

                if (!confirmacion)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario
                }
            }

            base.OnFormClosing(e);
        }
    }
}
