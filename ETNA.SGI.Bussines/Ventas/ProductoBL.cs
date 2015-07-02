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
    public class ProductoBL
    {

        ProductosDAO c = new ProductosDAO();
        public DataTable ObtenerProductos()
        {

            return c.ObtenerProductos();
        }

        public DataTable ObtenerProductosFiltro(String filtro)
        {

            return c.ObtenerProductosFiltro(filtro);
        }

        public  int obteneridproducto (String strcodigo)
        {

            return c.ObtenerCodigoIDProducto(strcodigo);
        }

    }
}
