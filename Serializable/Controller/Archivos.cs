
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializable.Controller
{
    class Archivos
    {
        private FileStream stream;
        private BinaryFormatter Formateador = new BinaryFormatter();

        public bool Serializar(object Equipo)
        {
            try
            {
                stream = new FileStream("..\\Equipos.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                Formateador.Serialize(stream, Equipo);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public object Deserializar()
        {
            try
            {
                object v;
                stream = new FileStream("..\\Equipos.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                v = Formateador.Deserialize(stream);
                stream.Close();
                return v;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
