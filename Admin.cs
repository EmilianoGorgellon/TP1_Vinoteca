using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public bool _isAdmin;

        private void showProduct()
        {
            Productos producto = new Productos();
            producto.TopLevel = false;
            producto.Dock = DockStyle.Fill;
            panel_admin.Controls.Clear();
            panel_admin.Controls.Add(producto);
            producto.IsAdmin = _isAdmin;
            producto.Show();
        }

        private void showClientes()
        {
            listaClientes clientes = new listaClientes();
            panel_admin.Controls.Clear();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(clientes);
            clientes.Show();
        }

        private void showCarrito()
        {
            Carrito carrit = new Carrito();
            panel_admin.Controls.Clear();
            carrit.TopLevel = false;
            carrit.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(carrit);
            carrit.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                clientesToolStripMenuItem.Visible = true;
            }
            showProduct();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showProduct();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showClientes();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto register = new RegistrarProducto();
            register.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrarse register = new Registrarse();
            register.isAdmin = _isAdmin;
            register.Show();
        }

        private void verCarritoToolStripMenuItem(object sender, EventArgs e)
        {
            showCarrito();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
