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
    public class VentaData
    {

        ///               Metodos para productos vendidos
        public static void CrearVenta(Venta venta)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "INSERT INTO Venta (Id,Comentario,IdUsuario)" +
                " VALUES(@Id, @Comentario, @IdUsuario); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                        


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

        public static void ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "UPDATE Venta " +
                "SET Id = @Id,Comentarios = @Comentarios,IdUsuario = @IdUsuario " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                        
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

        public static void EliminarVenta(Venta venta)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "DELETE FROM Venta " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });

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

        public static List<Venta> ListarVenta()
        {
            List<Venta> lista = new List<Venta>();

            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

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
                                    var venta = new Venta();
                                    venta.Id = Convert.ToInt32(dr["Id"]);
                                    venta.Comentarios = Convert.ToString(dr["Comentarios"]);
                                    venta.IdUsuario = Convert.ToString(dr["IdUsuario"]);
                                   


                                    lista.Add(venta);
                                }
                            }
                        }
                    }

                    // Opcional
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


