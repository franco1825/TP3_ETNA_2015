using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Bussines.Ventas;
using ETNA.SGI.Data.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public class PedidoBL
    {
        PedidoDAO pd = new PedidoDAO();



        public Boolean insertPedido(PedidoBE be , DataTable dt)
        {
            return pd.insertPedidoDetalle(be, dt);
        }

            public DataTable getpedidos(string strfiltro)
        {
            return pd.getpedidos(strfiltro);
        }
    }
    }

