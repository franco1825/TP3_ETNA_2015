using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Data.Ventas;

namespace ETNA.SGI.Bussines.Ventas 
{
    public  class ClienteBL 
    {
         ClientesDAO c = new ClientesDAO();
        public DataTable ObtenerClientes()
        {

            return c.ObtenerClientes();
        }

        public DataTable ObtenerClientesFiltro(String filtro)
        {

            return c.obtenerclientesFiltro(filtro);
        }

    }
}
