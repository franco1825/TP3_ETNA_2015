using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ETNA.SGI.Bussines.Ventas;

namespace ETNA.SGI.Presentacion.Formularios.Ventas
{
    public partial class frmCliente : Form
    {

      

        public frmCliente()
       
        {
            InitializeComponent();

            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
