using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ETNA.SGI.Data.Ventas;
using ETNA.SGI.Entity;

namespace ETNA.SGI.Bussines.Ventas
{
    public class DireccionBL
    {

        DireccionDAO d = new DireccionDAO();

        public DataTable getdirecciones(int cod,string str)

        {
            return d.ObtenerDireccion(cod, str);
        }

        public DireccionBE getdireccion(int cod)
        {
            return d.getdireccion(cod);
        }
    }
}
