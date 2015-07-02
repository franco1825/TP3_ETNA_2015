using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ETNA.SGI.Presentacion.Venta;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Presentacion
{
    public partial class MenuPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {

 
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        EmpleadosBE emp = new EmpleadosBE();
        public MenuPrincipal(EmpleadosBE be)
        {
            InitializeComponent();
            emp = be;
            barStaticItem8.Caption = "Bienvenido(a) : " + be.Nombres + be.Apellidos ;
            //label1.Text = "HOLA";

      
        }

  



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmPedido nuevo = new frmPedido(emp);
            frmConsultaPedido nuevo = new frmConsultaPedido(emp);
            nuevo.TopLevel = false;
            nuevo.AutoScroll = true;
            //nuevo.WindowState =
            nuevo.ControlBox = true;
            nuevo.AutoSize = true;
            PanelControl1.Controls.Add(nuevo);
            nuevo.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            /*aplicando el metodo forclosing para que cierre toda la plicacion y no se quede en memoria*/
            this.FormClosing += MenuPrincipal_FormClosed;
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConsultaPedido nuevo = new frmConsultaPedido();
            nuevo.TopLevel = false;
            nuevo.AutoScroll = true;
            //nuevo.WindowState =
            nuevo.ControlBox = true;
            nuevo.AutoSize = true;
            PanelControl1.Controls.Add(nuevo);
            nuevo.Show();
        }



    }
}