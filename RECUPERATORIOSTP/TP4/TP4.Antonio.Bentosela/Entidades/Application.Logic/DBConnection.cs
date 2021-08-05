using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Application.Logic
{
    public class DBConnection
    {
        /// <summary>
        /// Conexion que utiliza para guardar datos en una base de datos sql
        /// </summary>
        /// <param name="dato">numero de cuantos fueron atendidos</param>
        /// <param name="dato2">numero de cuantos no fueron atendidos</param>
        /// <returns>true or false</returns>
        public static bool GuardarMaterial(Producto p)
        {
            String connectionStr = @"Data Source=.;Initial Catalog = BaseFabrica7; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {                   
                    String consulta;
                    
                    consulta = $"SELECT * FROM dbo.Fabricados WHERE nombre = @nombre";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", p.Nombre);
                        connection.Open();
                        SqlDataReader lector = command.ExecuteReader();

                        while (lector.Read())
                        {
                            int stock = int.Parse(lector["stock"].ToString());
                            p.Stock += stock;
                        }
                        lector.Close();
                    }

                    consulta = $"UPDATE dbo.Fabricados SET stock=@stock WHERE nombre = @nombre";
                    
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", p.Nombre);                        
                        command.Parameters.AddWithValue("@stock", p.Stock);                        
                                         
                        int result = command.ExecuteNonQuery();
                        connection.Close();
                    }
                    
                    return true;
                }
            }
            catch (LogicException)
            {                 
                throw new LogicException("No se pudo guardar");                
            }
        }
    }
}
