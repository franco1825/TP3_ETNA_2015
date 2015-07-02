using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Data.Ventas;
using ETNA.SGI.Bussines.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public class MonedaBL
    {
        MonedadDAO ms = new MonedadDAO();

         public  List<Moneda> ObtenerMonedas()
         {
             

             return ms.ObtenerMonedas();
         }
             



    }
}
