using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ETNA.SGI.Entity.Ventas;
using System.Data.SqlClient;

namespace ETNA.SGI.Data.Ventas
{
    public class MonedadDAO
    {

        public  List<Moneda> ObtenerMonedas()
        {
            List<Moneda> _lista = new List<Moneda>();

            SqlConnection conexion = DConexion.obtenerBD();

            SqlCommand _comando = new SqlCommand("sp_vt_getmonedas", conexion);
            _comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Moneda pMoneda = new Moneda();

                pMoneda.idmoneda = _reader.GetInt32(0);

                pMoneda.descripcion = _reader.GetString(1);

                _lista.Add(pMoneda);
            }

            return _lista;
        }
    }
}
