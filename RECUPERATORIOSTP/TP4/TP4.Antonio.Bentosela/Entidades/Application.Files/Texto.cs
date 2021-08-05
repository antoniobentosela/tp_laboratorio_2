using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto : IFile<List<Producto>>
    {
        public bool Save(string file, List<Producto> data)
        {
            StreamWriter sw = new StreamWriter(file);
            bool retorno = false;
            try
            {
                if (data != null)
                {
                    foreach (Producto prod in data)
                    {

                        sw.WriteLine(prod.ToString());
                                               
                    }
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo guardar el archivo de texto", e);
            }
            finally
            {
                sw.Close();
            }
            return retorno;
        }
    }
}
