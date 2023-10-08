using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {

        ///               Metodos para productos vendidos
        public static void CrearProductoVendido(ProductoVendido productovendido)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "INSERT INTO ProductoVendido (Id,Stock,IdProducto, IdVenta)" +
                " VALUES(@Id, @Stock, @IdProducto, @IdVenta); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productovendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });
                        

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static void ModificarProductoVendido(ProductoVendido productovendido)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "UPDATE ProductoVendido " +
                "SET Id = @Id,Stock = @Stock,IdProducto = @IdProducto,IsVenta = @IdVenta " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productovendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });
                      

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productovendido)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "DELETE FROM ProductoVendido " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productovendido.Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ProductoVendido> ListarProductosVendido()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "SELECT Id,Stock,IdProducto,Idventa FROM ProductoVendido";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productovendido = new ProductoVendido();
                                    productovendido.Id = Convert.ToInt32(dr["Id"]);
                                    productovendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productovendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productovendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    

                                    lista.Add(productovendido);
                                }
                            }
                        }
                    }

                    
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}



