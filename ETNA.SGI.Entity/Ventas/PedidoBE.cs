using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Entity.Ventas
{
    public class PedidoBE
      {
          private Int32 _PKID;
          public Int32 PKID
          {
              get { return _PKID; }

              set { _PKID = value; }
          }

          private Int32 _IDCliente;
          public Int32 IDCliente
          {
              get { return _IDCliente; }

              set { _IDCliente = value; }
          }

          private DateTime _FechaEmision;
          public DateTime FechaEmision
          {
              get { return _FechaEmision; }

              set { _FechaEmision = value; }
          }

          private DateTime _FechaEntrega;
          public DateTime FechaEntrega
          {
              get { return _FechaEntrega; }

              set { _FechaEntrega = value; }
          }

          private Int32 _IDModalidadCredito;
          public Int32 IDModalidadCredito
          {
              get { return _IDModalidadCredito; }

              set { _IDModalidadCredito = value; }
          }

          private DateTime _FechaPago;
          public DateTime FechaPago
          {
              get { return _FechaPago; }

              set { _FechaPago = value; }
          }

          private bool _Credito;
          public bool Credito
          {
              get { return _Credito; }

              set { _Credito = value; }
          }

          private string _Direccion;
          public string Direccion
          {
              get { return _Direccion; }

              set { _Direccion = value; }
          }

          private Int32 _IDVendedor;
          public Int32 IDVendedor
          {
              get { return _IDVendedor; }

              set { _IDVendedor = value; }
          }

          private string _Observacion;
          public string Observacion
          {
              get { return _Observacion; }

              set { _Observacion = value; }
          }

          private bool _PrecioIncluyeImpuesto;
          public bool PrecioIncluyeImpuesto
          {
              get { return _PrecioIncluyeImpuesto; }

              set { _PrecioIncluyeImpuesto = value; }
          }

          private string _EstadoFacturacion;
          public string EstadoFacturacion
          {
              get { return _EstadoFacturacion; }

              set { _EstadoFacturacion = value; }
          }

          private string _DireccionEntrega;
          public string DireccionEntrega
          {
              get { return _DireccionEntrega; }

              set { _DireccionEntrega = value; }
          }

      }
}

