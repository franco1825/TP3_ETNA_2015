using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Windows.Forms;


namespace ETNA.SGI.Data.Ventas
{
    public class DireccionDAO
    {

        /*public static DataTable ObtenerDireccion()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "SELECT dbo.cliente.Nombre, dbo.Direccion.Descripcion AS direccion FROM dbo.Direccion RIGHT OUTER JOIN dbo.cliente ON dbo.Direccion.IdCliente = dbo.cliente.IdCliente WHERE  dbo.cliente.codigo ='0001';";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }*/

    }
}
