﻿namespace P52023_WirvingJ.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODECOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reipresiónDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MneSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReportes,
            this.MneSalir,
            this.MnuSalir});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 36);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoriasDeProductosToolStripMenuItem,
            this.rolesDeUsuarioToolStripMenuItem,
            this.tiposDeProveedorToolStripMenuItem,
            this.tiposDeCompraToolStripMenuItem});
            this.MnuGestiones.ForeColor = System.Drawing.Color.White;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(127, 32);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            this.gestionDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProveedoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(309, 6);
            // 
            // categoriasDeProductosToolStripMenuItem
            // 
            this.categoriasDeProductosToolStripMenuItem.Name = "categoriasDeProductosToolStripMenuItem";
            this.categoriasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.categoriasDeProductosToolStripMenuItem.Text = "Categorias de Productos";
            // 
            // rolesDeUsuarioToolStripMenuItem
            // 
            this.rolesDeUsuarioToolStripMenuItem.Name = "rolesDeUsuarioToolStripMenuItem";
            this.rolesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.rolesDeUsuarioToolStripMenuItem.Text = "Roles de Usuario";
            // 
            // tiposDeProveedorToolStripMenuItem
            // 
            this.tiposDeProveedorToolStripMenuItem.Name = "tiposDeProveedorToolStripMenuItem";
            this.tiposDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.tiposDeProveedorToolStripMenuItem.Text = "Tipos de Proveedor";
            // 
            // tiposDeCompraToolStripMenuItem
            // 
            this.tiposDeCompraToolStripMenuItem.Name = "tiposDeCompraToolStripMenuItem";
            this.tiposDeCompraToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.tiposDeCompraToolStripMenuItem.Text = "Tipos de Compra ";
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.BackColor = System.Drawing.Color.Black;
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODECOMPRASToolStripMenuItem});
            this.MnuProcesos.ForeColor = System.Drawing.Color.White;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(123, 32);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // rEGISTRODECOMPRASToolStripMenuItem
            // 
            this.rEGISTRODECOMPRASToolStripMenuItem.Name = "rEGISTRODECOMPRASToolStripMenuItem";
            this.rEGISTRODECOMPRASToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.rEGISTRODECOMPRASToolStripMenuItem.Text = "REGISTRO DE COMPRAS";
            this.rEGISTRODECOMPRASToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRODECOMPRASToolStripMenuItem_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorFechasToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.comprasPorProductoToolStripMenuItem,
            this.listadoDeInventarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.reipresiónDeCompraToolStripMenuItem});
            this.MnuReportes.ForeColor = System.Drawing.Color.White;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(116, 32);
            this.MnuReportes.Text = "REPORTES";
            // 
            // comprasPorFechasToolStripMenuItem
            // 
            this.comprasPorFechasToolStripMenuItem.Name = "comprasPorFechasToolStripMenuItem";
            this.comprasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.comprasPorFechasToolStripMenuItem.Text = "Compras por Fechas";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por Proveedor";
            // 
            // comprasPorProductoToolStripMenuItem
            // 
            this.comprasPorProductoToolStripMenuItem.Name = "comprasPorProductoToolStripMenuItem";
            this.comprasPorProductoToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.comprasPorProductoToolStripMenuItem.Text = "Compras Por Producto";
            // 
            // listadoDeInventarioToolStripMenuItem
            // 
            this.listadoDeInventarioToolStripMenuItem.Name = "listadoDeInventarioToolStripMenuItem";
            this.listadoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.listadoDeInventarioToolStripMenuItem.Text = "Listado de Inventario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // reipresiónDeCompraToolStripMenuItem
            // 
            this.reipresiónDeCompraToolStripMenuItem.Name = "reipresiónDeCompraToolStripMenuItem";
            this.reipresiónDeCompraToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.reipresiónDeCompraToolStripMenuItem.Text = "Reipresión de Compra ";
            // 
            // MneSalir
            // 
            this.MneSalir.ForeColor = System.Drawing.Color.White;
            this.MneSalir.Name = "MneSalir";
            this.MneSalir.Size = new System.Drawing.Size(76, 32);
            this.MneSalir.Text = "SALIR";
            this.MneSalir.Click += new System.EventHandler(this.sAÑIRToolStripMenuItem_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.Color.White;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(111, 32);
            this.MnuSalir.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Ivory;
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 20);
            this.LblUsuario.Text = "usuario";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "SISTEMA DE COMPRAS PROGRA 5 2023-1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MneSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODECOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reipresiónDeCompraToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
    }
}