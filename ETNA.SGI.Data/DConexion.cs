using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ETNA.SGI.Data
{


    public class DConexion
    {


        public static SqlConnection obtenerBD()
        {

            string conexion = app.Default.Setting;

            string datosConexion = conexion;
            SqlConnection con = new SqlConnection(datosConexion);
            con.Open();

            return con;

        }



    }

}