using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETNA.SGI.Bussines.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Presentacion.Venta
{
    public partial class frmConsultarAlmacen : DevExpress.XtraEditors.XtraForm
    {
        frmPedido frmpedido;

        AlmacenBL alma = new AlmacenBL();

        public frmConsultarAlmacen(frmPedido frm)
        {
            InitializeComponent();

            this.frmpedido = frm;
            DataGridView1.DataSource = alma.ObtenerAlmacenes();
            DataGridView1.AllowUserToAddRows = false;


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            frmpedido.txtCodAlmacen.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
            frmpedido.txtNomAlmacen.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
            this.Close();
         
        }

        private void frmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = alma.ObtenerAlmacenesfiltro(textBox1.Text);

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
}
