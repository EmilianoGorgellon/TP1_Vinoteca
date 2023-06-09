﻿namespace TP1_UTN
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            verProductosToolStripMenuItem = new ToolStripMenuItem();
            carritoToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            exportarACSVToolStripMenuItem = new ToolStripMenuItem();
            exportarAJSONToolStripMenuItem = new ToolStripMenuItem();
            exportarAPDFToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel_admin = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1148, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, carritoToolStripMenuItem, logToolStripMenuItem, informesToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, verClientesToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.VisibleChanged += Admin_Load;
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(154, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(154, 22);
            verClientesToolStripMenuItem.Text = "Ver clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductoToolStripMenuItem, verProductosToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(168, 22);
            agregarProductoToolStripMenuItem.Text = "Agregar producto";
            agregarProductoToolStripMenuItem.Visible = false;
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(168, 22);
            verProductosToolStripMenuItem.Text = "Ver productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // carritoToolStripMenuItem
            // 
            carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            carritoToolStripMenuItem.Size = new Size(180, 22);
            carritoToolStripMenuItem.Text = "Carrito";
            carritoToolStripMenuItem.Click += verCarritoToolStripMenuItem;
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(180, 22);
            logToolStripMenuItem.Text = "Logs";
            logToolStripMenuItem.Visible = false;
            logToolStripMenuItem.Click += logToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarACSVToolStripMenuItem, exportarAJSONToolStripMenuItem, exportarAPDFToolStripMenuItem });
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(180, 22);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Visible = false;
            // 
            // exportarACSVToolStripMenuItem
            // 
            exportarACSVToolStripMenuItem.Name = "exportarACSVToolStripMenuItem";
            exportarACSVToolStripMenuItem.Size = new Size(180, 22);
            exportarACSVToolStripMenuItem.Text = "Exportar a CSV";
            exportarACSVToolStripMenuItem.Click += exportarACSVToolStripMenuItem_Click;
            // 
            // exportarAJSONToolStripMenuItem
            // 
            exportarAJSONToolStripMenuItem.Name = "exportarAJSONToolStripMenuItem";
            exportarAJSONToolStripMenuItem.Size = new Size(180, 22);
            exportarAJSONToolStripMenuItem.Text = "Exportar a JSON";
            exportarAJSONToolStripMenuItem.Click += exportarAJSONToolStripMenuItem_Click;
            // 
            // exportarAPDFToolStripMenuItem
            // 
            exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            exportarAPDFToolStripMenuItem.Size = new Size(180, 22);
            exportarAPDFToolStripMenuItem.Text = "Exportar a PDF";
            exportarAPDFToolStripMenuItem.Click += exportarAPDFToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // panel_admin
            // 
            panel_admin.Location = new Point(0, 27);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(1156, 542);
            panel_admin.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1148, 561);
            Controls.Add(panel_admin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            ShowIcon = false;
            Text = "Vinoteca";
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private Panel panel_admin;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem verClientesToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private ToolStripMenuItem carritoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem exportarACSVToolStripMenuItem;
        private ToolStripMenuItem exportarAJSONToolStripMenuItem;
        private ToolStripMenuItem exportarAPDFToolStripMenuItem;
    }
}