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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public bool _isAdmin;
        private string _idUsername;

        public string IdUsername { get { return _idUsername; } set { _idUsername = value; } }
        private void showProduct()
        {
            Productos producto = new Productos();
            producto.TopLevel = false;
            producto.Dock = DockStyle.Fill;
            panel_admin.Controls.Clear();
            panel_admin.Controls.Add(producto);
            producto.IsAdmin = _isAdmin;
            producto.IdUsername = IdUsername;
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
            carrit.IdUsername = IdUsername;
            panel_admin.Controls.Add(carrit);
            carrit.Show();
        }
        private void showLogs()
        {
            Log log = new Log();
            panel_admin.Controls.Clear();
            log.TopLevel = false;
            log.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(log);
            log.Show();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                clientesToolStripMenuItem.Visible = true;
                agregarProductoToolStripMenuItem.Visible = true;
                logToolStripMenuItem.Visible = true;
                informesToolStripMenuItem.Visible = true;
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
            register.ConfirmacionCierreHandler += ConfirmarCierreFormulario;

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

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLogs();
        }

        private async void exportarACSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await Informes.ExportarProductosACsv());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void exportarAJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (await Informes.ExportarProductosAJSON("productos"))
                {
                    MessageBox.Show("Se creo satisfactoriamente el archivo productos.json");
                } else
                {
                    MessageBox.Show("No se pudo crear el archivo productos.json");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await Informes.ExportarProductosAPDF());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ConfirmarCierreFormulario()
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (result == DialogResult.Yes);
        }
    }
}
