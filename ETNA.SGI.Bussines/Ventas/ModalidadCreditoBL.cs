using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Data.Ventas;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Bussines.Ventas
{
    public class ModalidadCreditoBL
    {

        ModalidaCreditoDAO bl = new ModalidaCreditoDAO();

        public ModalidadCreditoBE getmodalidad(int cod)
        {
            return bl.getmodalidad(cod);
        }

    }
}
