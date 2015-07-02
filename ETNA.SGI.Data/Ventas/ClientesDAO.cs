using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using  ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Data.Ventas
{
    public class ClientesDAO
    {

        public  DataTable ObtenerClientes()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_get_clientes";
            
            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }


        public DataTable obtenerclientesFiltro(string filtro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_get_clientes_filtro";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", filtro));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        /*
            // Cargar clientes
             SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "select a.codigo, trim(a.primernombre)+' '+trim(a.apellidopaterno) nombre, (select b.descripcion from direccion b where a.idcliente = b.idcliente) direccion, a.docidentidad from cliente a;";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);
            DataGridView1.DataSource = datos;

            con.Close();
         */

    }
}
