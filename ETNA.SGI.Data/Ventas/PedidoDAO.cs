using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Entity.Ventas;

namespace ETNA.SGI.Data.Ventas
{
    public class PedidoDAO
    {
        ProductosDAO prodao = new ProductosDAO();

        public  Boolean insertPedidoDetalle(PedidoBE be,DataTable dt)
        {


            String con = app.Default.Setting;


            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;


                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection 
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                                   "sp_vt_insertpedido";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
                    OutputParam.Direction = ParameterDirection.Output;command.Parameters.Add(OutputParam);
                    
                    command.Parameters.Add(
              new SqlParameter("@IDcliente", be.IDCliente));
                    command.Parameters.Add(
              new SqlParameter("@fechaemision", be.FechaEmision));
                    command.Parameters.Add(
              new SqlParameter("@fechaentrega", be.FechaEntrega));
                    command.Parameters.Add(
              new SqlParameter("@idmoddalidadcredito", be.IDModalidadCredito));
                    command.Parameters.Add(
              new SqlParameter("@fechapago", be.FechaPago));
                          command.Parameters.Add(
              new SqlParameter("@credito", be.Credito));
                          command.Parameters.Add(
              new SqlParameter("@direccion", be.Direccion));
                          command.Parameters.Add(
              new SqlParameter("@idvendedor", be.IDVendedor));
                          command.Parameters.Add(
              new SqlParameter("@observacion", be.Observacion));
                          command.Parameters.Add(
              new SqlParameter("@precioincluyeim", be.PrecioIncluyeImpuesto));
                          command.Parameters.Add(
              new SqlParameter("@estadofactura", be.EstadoFacturacion));
                          command.Parameters.Add(
              new SqlParameter("@direccionentrega", be.DireccionEntrega));
                      
                    command.ExecuteNonQuery();



                    int codigo = int.Parse(command.Parameters["@CodCodigo"].Value.ToString());

                    if (codigo == 0)
                    {
                        codigo = 1;}

  

                    /*EL DETALLE*/

                    foreach (DataRow row in dt.Rows)
                {
                    command.CommandText = "sp_vt_insertdetpedido";

                    command.CommandType = CommandType.StoredProcedure;

                    String stridproducto = (row[0].ToString());

                    int codigoperu = prodao.ObtenerCodigoIDProducto(stridproducto);
                         

                    double cantidad = double.Parse(row[3].ToString());
                    double precio = double.Parse(row[2].ToString()); 
  
                        command.Parameters.Clear();
           command.Parameters.Add(
          new SqlParameter("@idproducto", codigoperu ));
                    command.Parameters.Add(
          new SqlParameter("@cantidad", cantidad));
                    command.Parameters.Add(
         new SqlParameter("@precio", precio));
                    command.Parameters.Add(
          new SqlParameter("@observacion", "BLABLABLA"));
                    command.Parameters.Add(
          new SqlParameter("@IdPedido", codigo));
                        

                    command.ExecuteNonQuery();
                }


                    

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");

                    return true;
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception ex2)
                    {
                        return false;


                        // This catch block will handle any errors that may have occurred 
                        // on the server that would cause the rollback to fail, such as 
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

 


        public DataTable getpedidos(string strfiltro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getpedidos";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;
            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", strfiltro));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }
    }
}

