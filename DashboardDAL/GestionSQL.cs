using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Utilidades.VO;

namespace DashboardDAL
{
    public class GestionSQL
    {
        public GestionSQL() { }

        public CLienteVO DatosClienteSQL(string iDCliente)
        {
            CLienteVO cliente = ExtraerDatosClienteSQL(iDCliente);
            return cliente;
        }

        private CLienteVO ExtraerDatosClienteSQL(string iDCliente)
        {
            CLienteVO cliente = new CLienteVO();
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT * FROM dbo.Customers WHERE CustomerID='" + iDCliente + "'";

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();

                while (datosSQL.Read())
                {
                    cliente.IDCliente = datosSQL.GetValue(0).ToString();
                    cliente.NombreEmpresa = datosSQL.GetValue(1).ToString();
                    cliente.NombreContacto = datosSQL.GetValue(2).ToString();
                    cliente.CategoriaContacto = datosSQL.GetValue(3).ToString();
                    cliente.Direccion = datosSQL.GetValue(4).ToString();
                    cliente.Ciudad = datosSQL.GetValue(5).ToString();
                    cliente.Region = datosSQL.GetValue(6).ToString();
                    cliente.CodigoPostal = datosSQL.GetValue(7).ToString();
                    cliente.Pais = datosSQL.GetValue(8).ToString();
                    cliente.Telefono = datosSQL.GetValue(9).ToString();
                    cliente.Fax = datosSQL.GetValue(10).ToString();
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return cliente;
        }

        public List<PedidoVO> ListadoPedidosSQL(string iDCliente)
        {
            List<PedidoVO> listadoPedidos = ExtraerListadoPedidosSQL(iDCliente);
            return listadoPedidos;
        }

        private List<PedidoVO> ExtraerListadoPedidosSQL(string iDCliente)
        {
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT ord.OrderID, ord.CustomerID, cust.CompanyName, ord.ShippedDate, ship.CompanyName,
                                          ord.Freight, ord.ShipName, ord.ShipAddress, ord.ShipCity, ord.ShipRegion,
                                          ord.ShipPostalCode, ord.ShipCountry
                                   FROM dbo.Shippers ship
                                   INNER JOIN dbo.Orders ord ON ord.ShipVia = ship.ShipperID
                                   INNER JOIN dbo.Customers cust ON ord.CustomerID = cust.CustomerID
                                   WHERE ord.CustomerID = '" + iDCliente + "'";

            List<PedidoVO> listadoPedidos = new List<PedidoVO>();

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();


                while (datosSQL.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    pedido.IDPedido = (int)Int64.Parse(datosSQL.GetValue(0).ToString());
                    pedido.IDCliente = datosSQL.GetValue(1).ToString();
                    pedido.NombreEmpresa = datosSQL.GetValue(2).ToString();
                    pedido.FechaEnvio = DateTime.Parse(datosSQL.GetValue(3).ToString());
                    pedido.AgenciaEnvio = datosSQL.GetValue(4).ToString();
                    pedido.ImporteEnvio = (double)Double.Parse(datosSQL.GetValue(5).ToString());
                    pedido.Destinatario = datosSQL.GetValue(6).ToString();
                    pedido.DireccionEntrega = datosSQL.GetValue(7).ToString();
                    pedido.PoblacionEntrega = datosSQL.GetValue(8).ToString();
                    pedido.RegionEntrega = datosSQL.GetValue(9).ToString();
                    pedido.CodigoPostalEntrega = datosSQL.GetValue(10).ToString();
                    pedido.PaisEntrega = datosSQL.GetValue(11).ToString();

                    listadoPedidos.Add(pedido);
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return listadoPedidos;
        }

        public List<DetallePedidoVO> DetallePedidoSQL(int iDPedido)
        {
            List<DetallePedidoVO> detallePedido = ExtraerDetallePedidoSQL(iDPedido);
            return detallePedido;
        }

        private List<DetallePedidoVO> ExtraerDetallePedidoSQL(int iDPedido)
        {
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT det.OrderID, det.ProductID, prod.ProductName, det.UnitPrice, det.Quantity, det.Discount
                                   FROM dbo.[Order Details] det
                                   INNER JOIN dbo.Products prod ON det.ProductID=prod.ProductID
                                   WHERE det.OrderID ='" + iDPedido + "'";

            List<DetallePedidoVO> detallePedido = new List<DetallePedidoVO>();

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();


                while (datosSQL.Read())
                {
                    DetallePedidoVO lineaDetalle = new DetallePedidoVO();

                    lineaDetalle.IDPedido = (int)Int64.Parse(datosSQL.GetValue(0).ToString());
                    lineaDetalle.IDProducto = (int)Int64.Parse(datosSQL.GetValue(1).ToString());
                    lineaDetalle.NombreProducto = datosSQL.GetValue(2).ToString();
                    lineaDetalle.Precio = (double)Double.Parse(datosSQL.GetValue(3).ToString());
                    lineaDetalle.Cantidad = (int)Int64.Parse(datosSQL.GetValue(4).ToString());
                    lineaDetalle.Descuento = (double)Double.Parse(datosSQL.GetValue(5).ToString());

                    detallePedido.Add(lineaDetalle);
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return detallePedido;

        }

        public List<DetallePedidoVO> DetallePedidosClienteSQL(string iDCliente)
        {
            List<DetallePedidoVO> detallePedido = ExtraerDetallePedidoClienteSQL(iDCliente);
            return detallePedido;
        }

        private List<DetallePedidoVO> ExtraerDetallePedidoClienteSQL(string iDCliente)
        {
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT * FROM dbo.[Order Details] det
                                   INNER JOIN dbo.Orders ord ON det.OrderID=ord.OrderID
                                   WHERE ord.CustomerID='" + iDCliente + "'";

            List<DetallePedidoVO> detallePedido = new List<DetallePedidoVO>();

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();


                while (datosSQL.Read())
                {
                    DetallePedidoVO lineaDetalle = new DetallePedidoVO();

                    lineaDetalle.IDPedido = (int)Int64.Parse(datosSQL.GetValue(0).ToString());
                    lineaDetalle.IDProducto = (int)Int64.Parse(datosSQL.GetValue(1).ToString());
                    lineaDetalle.Precio = (double)Double.Parse(datosSQL.GetValue(2).ToString());
                    lineaDetalle.Cantidad = (int)Int64.Parse(datosSQL.GetValue(3).ToString());
                    lineaDetalle.Descuento = (double)Double.Parse(datosSQL.GetValue(4).ToString());
                    lineaDetalle.FechaEnvio = DateTime.Parse(datosSQL.GetValue(10).ToString());

                    detallePedido.Add(lineaDetalle);
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return detallePedido;

        }

        public List<CLienteVO> ClientesSQL()
        {
            List<CLienteVO> clientes = ExtraerClientesSQL();
            return clientes;
        }

        private List<CLienteVO> ExtraerClientesSQL()
        {
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT * FROM dbo.Customers";

            List<CLienteVO> clientes = new List<CLienteVO>();

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();


                while (datosSQL.Read())
                {
                    CLienteVO cliente = new CLienteVO();

                    cliente.IDCliente = datosSQL.GetValue(0).ToString();
                    cliente.NombreEmpresa = datosSQL.GetValue(1).ToString();
                    cliente.NombreContacto = datosSQL.GetValue(2).ToString();
                    cliente.CategoriaContacto = datosSQL.GetValue(3).ToString();
                    cliente.Direccion = datosSQL.GetValue(4).ToString();
                    cliente.Ciudad = datosSQL.GetValue(5).ToString();
                    cliente.Region = datosSQL.GetValue(6).ToString();
                    cliente.CodigoPostal = datosSQL.GetValue(7).ToString();
                    cliente.Pais = datosSQL.GetValue(8).ToString();
                    cliente.Telefono = datosSQL.GetValue(9).ToString();
                    cliente.Fax = datosSQL.GetValue(10).ToString();

                    clientes.Add(cliente);
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return clientes;
        }

        public List<CLienteVO> BusquedaClientesSQL(String textoBusqueda)
        {
            List<CLienteVO> clientes = ExtraerBusquedaClientesSQL(textoBusqueda);
            return clientes;
        }

        private List<CLienteVO> ExtraerBusquedaClientesSQL(String textoBusqueda)
        {
            SqlConnection conexionSQL = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID = di; Password = 1234");
            SqlCommand comandoSQL;
            SqlDataReader datosSQL;

            string consultaSQL = @"SELECT * FROM dbo.Customers
                                            WHERE CustomerID LIKE '%" + textoBusqueda + "%' OR CompanyName LIKE '%" + textoBusqueda + "%'";

            List<CLienteVO> clientes = new List<CLienteVO>();

            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand(consultaSQL, conexionSQL);

                datosSQL = comandoSQL.ExecuteReader();


                while (datosSQL.Read())
                {
                    CLienteVO cliente = new CLienteVO();

                    cliente.IDCliente = datosSQL.GetValue(0).ToString();
                    cliente.NombreEmpresa = datosSQL.GetValue(1).ToString();
                    cliente.NombreContacto = datosSQL.GetValue(2).ToString();
                    cliente.CategoriaContacto = datosSQL.GetValue(3).ToString();
                    cliente.Direccion = datosSQL.GetValue(4).ToString();
                    cliente.Ciudad = datosSQL.GetValue(5).ToString();
                    cliente.Region = datosSQL.GetValue(6).ToString();
                    cliente.CodigoPostal = datosSQL.GetValue(7).ToString();
                    cliente.Pais = datosSQL.GetValue(8).ToString();
                    cliente.Telefono = datosSQL.GetValue(9).ToString();
                    cliente.Fax = datosSQL.GetValue(10).ToString();

                    clientes.Add(cliente);
                }

                datosSQL.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer la conexión");
            }
            finally
            {
                conexionSQL.Close();
            }

            return clientes;
        }
    }
}
