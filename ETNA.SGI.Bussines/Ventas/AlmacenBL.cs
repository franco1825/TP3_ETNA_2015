using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Data;
using ETNA.SGI.Data.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public class AlmacenBL
    {
        AlmacenesDAO almdao = new AlmacenesDAO();
        public DataTable ObtenerAlmacenes()
        {

            return almdao.ObtenerAlmacenes();
        }

        public DataTable ObtenerAlmacenesfiltro(string filtro)
        {

            return almdao.obteneralmacenesFiltro(filtro);
        }


    }
}
