using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ETNA.SGI.Bussines.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Presentacion.Venta
{
    

    public partial class frmConsultaPedido : DevExpress.XtraEditors.XtraForm
    {

        PedidoBL pbl = new PedidoBL();

        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        public EmpleadosBE emp = new EmpleadosBE();

        public frmConsultaPedido(EmpleadosBE be)
        {
            InitializeComponent();
            emp = be;
        }

        private void frmConsultaPedido_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbl.getpedidos("");
        dataGridView1.AllowUserToAddRows = false;}

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbl.getpedidos("");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmPedido(emp).ShowDialog();
        }
    }
}