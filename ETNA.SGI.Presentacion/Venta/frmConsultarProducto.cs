using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETNA.SGI.Entity.Ventas;
using ETNA.SGI.Bussines.Ventas;

namespace ETNA.SGI.Presentacion.Venta
{
    public partial class frmConsultarProducto : DevExpress.XtraEditors.XtraForm
    {
        frmPedido frmpedido;

        ProductoBL pb = new ProductoBL();
        PedidoDetalle ped = new PedidoDetalle();

        public frmConsultarProducto(frmPedido frm)
        {
            InitializeComponent();

            this.frmpedido = frm;
            
            dataGridView1.DataSource = pb.ObtenerProductos();
            dataGridView1.AllowUserToAddRows = false;

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Boolean modificado = false;
            string codigo = this.dataGridView1.SelectedCells[0].Value.ToString();
            if (frmpedido.dtdetalle.Rows.Count >= 1)
            {


                foreach (DataRow row in frmpedido.dtdetalle.Rows)
                {
                   String codigodetalle = row[0].ToString();
                    if (codigodetalle == codigo)
                    {
                        row[3] = int.Parse(row[3].ToString())  + 1;
                        modificado = true;
                    }

                }

            }

                if ( modificado == true)
                {
                    MessageBox.Show("Se Agregara una cantidad al producto");
                }
                else
                {
                    if (frmpedido.Name == "frmPedido")
                    {

                        frmpedido.dtdetalle.Rows.Add(codigo,
                                   this.dataGridView1.SelectedCells[1].Value.ToString(),
                                   Double.Parse(this.dataGridView1.SelectedCells[2].Value.ToString()),
                                   1);

                        

                        this.Close();
                    }  
               




                
            }

                frmpedido.actualizarDetalle();
                frmpedido.actualizarmontos();
               this.Close();
           

         
            
           
            //frmpedido.dtgDetalleProd.DataSource = null;
            //frmpedido.dtgDetalleProd.DataSource = frmpedido.dtDetPedido;

            //foreach (DataGridViewRow row in frmpedido.dtgDetalleProd.Rows) ;

           // double resultado = 0;
            //double total1 = 0;

            /*foreach (DataGridViewRow row in frmpedido.dtgDetalleProd.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["preciounitario"].Value) * Convert.ToDouble(row.Cells["cantidad"].Value));
                row.Cells["total"].Value = resultado;
                total1 += Convert.ToDouble(row.Cells["total"].Value);

                frmpedido.txtafecto.Text = Convert.ToString(total1);
                frmpedido.txtimpuesto.Text = Convert.ToString(total1 * 0.18);
                frmpedido.txttotal.Text = Convert.ToString((total1 * 0.18) + total1);



            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
                textBox2.Text = "";
            }


        }

        private void frmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
            textBox2.Text = "";
        }

       }
}
