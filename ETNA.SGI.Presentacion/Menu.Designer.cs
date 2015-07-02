namespace ETNA.SGI.Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstracionSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resquisicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulaciónDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoComercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobacionSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.stStrip00 = new System.Windows.Forms.ToolStripProgressBar();
            this.stStrip01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stStrip02 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stStrip03 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stStrip04 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.tsbExit,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(87, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 61);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ETNA.SGI.Presentacion.Properties.Resources.CALCULA;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 51);
            this.toolStripButton1.Text = "Calc.";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::ETNA.SGI.Presentacion.Properties.Resources.close;
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 51);
            this.tsbExit.Text = "&Salir";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.consultasToolStripMenuItem1,
            this.reportesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(87, 401);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeToolStripMenuItem,
            this.adminstracionSistemaToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // administraciónDeToolStripMenuItem
            // 
            this.administraciónDeToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.ACCESOS;
            this.administraciónDeToolStripMenuItem.Name = "administraciónDeToolStripMenuItem";
            this.administraciónDeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.administraciónDeToolStripMenuItem.Text = "Cambio de Contraseña";
            // 
            // adminstracionSistemaToolStripMenuItem
            // 
            this.adminstracionSistemaToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.mant;
            this.adminstracionSistemaToolStripMenuItem.Name = "adminstracionSistemaToolStripMenuItem";
            this.adminstracionSistemaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.adminstracionSistemaToolStripMenuItem.Text = "Administración Sistema";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.ACERCA_DE;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.close;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.salirToolStripMenuItem.Text = "Salir...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resquisicionesToolStripMenuItem,
            this.planificacionToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.transaccionesToolStripMenuItem.Text = "&Ventas";
            // 
            // resquisicionesToolStripMenuItem
            // 
            this.resquisicionesToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.FACTURAR12;
            this.resquisicionesToolStripMenuItem.Name = "resquisicionesToolStripMenuItem";
            this.resquisicionesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.resquisicionesToolStripMenuItem.Text = "Pedidos";
            this.resquisicionesToolStripMenuItem.Click += new System.EventHandler(this.resquisicionesToolStripMenuItem_Click);
            // 
            // planificacionToolStripMenuItem
            // 
            this.planificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem});
            this.planificacionToolStripMenuItem.Name = "planificacionToolStripMenuItem";
            this.planificacionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.planificacionToolStripMenuItem.Text = "Planificacion";
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaIngresoToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.mantenimientosToolStripMenuItem.Text = "&Compras";
            // 
            // notaIngresoToolStripMenuItem
            // 
            this.notaIngresoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notaIngresoToolStripMenuItem.Image")));
            this.notaIngresoToolStripMenuItem.Name = "notaIngresoToolStripMenuItem";
            this.notaIngresoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.notaIngresoToolStripMenuItem.Text = "Menu Compras";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requerimientoToolStripMenuItem,
            this.anulaciónDeFacturaToolStripMenuItem,
            this.formatoComercialToolStripMenuItem,
            this.aprobacionSolicitudToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.consultasToolStripMenuItem.Text = "&Exportacion";
            // 
            // requerimientoToolStripMenuItem
            // 
            this.requerimientoToolStripMenuItem.Name = "requerimientoToolStripMenuItem";
            this.requerimientoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.requerimientoToolStripMenuItem.Text = "Requerimiento ";
            this.requerimientoToolStripMenuItem.Click += new System.EventHandler(this.requerimientoToolStripMenuItem_Click);
            // 
            // anulaciónDeFacturaToolStripMenuItem
            // 
            this.anulaciónDeFacturaToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.BO12;
            this.anulaciónDeFacturaToolStripMenuItem.Name = "anulaciónDeFacturaToolStripMenuItem";
            this.anulaciónDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.anulaciónDeFacturaToolStripMenuItem.Text = "Solicitud de Atención";
            this.anulaciónDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.anulaciónDeFacturaToolStripMenuItem_Click);
            // 
            // formatoComercialToolStripMenuItem
            // 
            this.formatoComercialToolStripMenuItem.Image = global::ETNA.SGI.Presentacion.Properties.Resources.FACTURAR12;
            this.formatoComercialToolStripMenuItem.Name = "formatoComercialToolStripMenuItem";
            this.formatoComercialToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.formatoComercialToolStripMenuItem.Text = "Formato Comercial";
            this.formatoComercialToolStripMenuItem.Click += new System.EventHandler(this.formatoComercialToolStripMenuItem_Click);
            // 
            // aprobacionSolicitudToolStripMenuItem
            // 
            this.aprobacionSolicitudToolStripMenuItem.Name = "aprobacionSolicitudToolStripMenuItem";
            this.aprobacionSolicitudToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aprobacionSolicitudToolStripMenuItem.Text = "Aprobación Solicitud";
            this.aprobacionSolicitudToolStripMenuItem.Click += new System.EventHandler(this.aprobacionSolicitudToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(74, 19);
            this.consultasToolStripMenuItem1.Text = "&Consultas";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(74, 19);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // stStrip
            // 
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStrip00,
            this.stStrip01,
            this.stStrip02,
            this.stStrip03,
            this.stStrip04});
            this.stStrip.Location = new System.Drawing.Point(87, 379);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(604, 22);
            this.stStrip.TabIndex = 10;
            this.stStrip.Text = "statusStrip1";
            // 
            // stStrip00
            // 
            this.stStrip00.Name = "stStrip00";
            this.stStrip00.Size = new System.Drawing.Size(300, 16);
            // 
            // stStrip01
            // 
            this.stStrip01.Name = "stStrip01";
            this.stStrip01.Size = new System.Drawing.Size(111, 17);
            this.stStrip01.Text = "Aplicación: nombre";
            // 
            // stStrip02
            // 
            this.stStrip02.Name = "stStrip02";
            this.stStrip02.Size = new System.Drawing.Size(83, 17);
            this.stStrip02.Text = "Usuario: name";
            // 
            // stStrip03
            // 
            this.stStrip03.Name = "stStrip03";
            this.stStrip03.Size = new System.Drawing.Size(41, 17);
            this.stStrip03.Text = "Fecha:";
            // 
            // stStrip04
            // 
            this.stStrip04.Name = "stStrip04";
            this.stStrip04.Size = new System.Drawing.Size(36, 17);
            this.stStrip04.Text = "Hora:";
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Location = new System.Drawing.Point(90, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(601, 312);
            this.panelControl1.TabIndex = 11;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(691, 401);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP Baterias ETNA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resquisicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulaciónDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem adminstracionSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStripProgressBar stStrip00;
        private System.Windows.Forms.ToolStripStatusLabel stStrip01;
        private System.Windows.Forms.ToolStripStatusLabel stStrip02;
        private System.Windows.Forms.ToolStripStatusLabel stStrip03;
        private System.Windows.Forms.ToolStripStatusLabel stStrip04;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem requerimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoComercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobacionSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

