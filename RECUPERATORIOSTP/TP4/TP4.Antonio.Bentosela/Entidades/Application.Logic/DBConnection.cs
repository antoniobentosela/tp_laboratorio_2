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
        public static bool GuardarMaterial(int dato)
        {
            String connectionStr = @"Data Source=.;Initial Catalog = BaseFabrica; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand comando;
                    comando = new SqlCommand();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Connection = connection;
                    String consulta;

                    consulta = $"INSERT INTO Fabricados (Fabricados)  VALUES ({dato})";
                    comando.CommandText = consulta;                   
                    comando.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
