using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Data.Ventas
{
    public class AlmacenesDAO
    {

        public  DataTable ObtenerAlmacenes()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getalmacenes";

            SqlCommand cmd = new SqlCommand(textoCmd, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        public DataTable obteneralmacenesFiltro(string filtro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getalmacenesfiltro";

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


    }
}
