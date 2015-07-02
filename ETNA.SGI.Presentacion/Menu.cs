using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ETNA.SGI.Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Process pr = new Process();

        private void Menu_Load(object sender, EventArgs e)
        {
            stStrip00.Visible = false;
            //stStrip01.Text = "Sistema ETNA      ";
            //stStrip02.Text = "Usuario: " + Program.Usuario.Trim();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //stStrip03.Text = "Fecha: " + DateTime.Now.ToShortDateString().ToString();
            //stStrip04.Text = "Hora: " + DateTime.Now.ToLongTimeString().ToString();
        }

        private void resquisicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();

            //Formularios.Ventas.frmPedido frm = new Formularios.Ventas.frmPedido();
            //frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void anulaciónDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formularios.Exportacion.frmAtencionSolicitud frm = new Formularios.Exportacion.frmAtencionSolicitud();
            //frm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pr.StartInfo.FileName = "calc.exe";
            //pr.Start();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pr.StartInfo.FileName = "calc.exe";
            pr.Start();
        }

        private void requerimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Formularios.Exportacion.frmActualizarInfoRequerimiento frm = new Formularios.Exportacion.frmActualizarInfoRequerimiento();
           // frm.Show();
        }

        private void formatoComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formularios.Exportacion.frmBusquedaFormatoComercial frm = new Formularios.Exportacion.frmBusquedaFormatoComercial();
            //frm.Show();
        }

        private void aprobacionSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formularios.Exportacion.frmAprobacionSolicitud frm = new Formularios.Exportacion.frmAprobacionSolicitud();
            //frm.Show();
        }

        private void planificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formularios.Ventas.frmListPrecios frm = new Formularios.Ventas.frmListPrecios();
            //frm.Show();
        }

    }
}
