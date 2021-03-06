﻿using System;
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

        public Boolean deletepedido(int codigo)
        {
            return pd.DELETEPEDIDOS(codigo);
        }

        public Boolean uptpedido(int codigopedido,int concliente,DateTime fecemision,DateTime fecentrega)
        {
            return pd.updtpedido(codigopedido,concliente,fecemision,fecentrega);
        }



            public DataTable getpedidos(string strfiltro)
        {
            return pd.getpedidos(strfiltro);
        }


            public PedidoBE getpedido(int cod)
            {
                return pd.getPedido(cod);
            }

            public DataTable getdetallepedido(int cod)
            {
                return pd.obtenerDetalledPedidos(cod);
            }


            public Boolean deldetallepedido(int cod)
            {
                return pd.deletedetallepedido(cod);
            }

            public Boolean updetallepedido(int cod,double d)
            {
                return pd.updatedetallepedido(cod,d);
            }

        public  Boolean inserdetpedido(PedidoDetalleBE be)
            {
                return pd.insertDetallePedido(be);
            }

                   
                     

    }
    }

