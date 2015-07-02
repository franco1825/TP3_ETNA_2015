using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETNA.SGI.Data.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public  class AutenticacionBL
    {

        AutenticacionDAO a = new AutenticacionDAO();

        public  EmpleadosBE Autenticacion(string usu , string pass)
        {
            return a.Autenticacion(usu, pass);
        }
    }
}
