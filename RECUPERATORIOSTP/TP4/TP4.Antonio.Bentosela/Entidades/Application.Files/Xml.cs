using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml<T> : IFile<T> where T : class, new()
    {
        public bool Save(string file, T data)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;

                try
                {
                    writer = new XmlTextWriter(file, Encoding.UTF8);
                    writer.Formatting = Formatting.Indented;
                    serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, data);
                }
                catch (Exception)
                {
                    throw new Exception("No se pudo Serializar el archivo");
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            return true;
        }
          
            
    }
}

