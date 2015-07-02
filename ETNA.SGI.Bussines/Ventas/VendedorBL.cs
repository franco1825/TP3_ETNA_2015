using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETNA.SGI.Data.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public class VendedorBL
    {
        VendedoresDAO v = new VendedoresDAO();

        public DataTable getvendedores(string fil)
        {
            return v.ObtenerVendedores(fil);
        }


        public EmpleadosBE getvendedor(int cod)
        {
            return v.getempleado(cod);
        }
    }
}
