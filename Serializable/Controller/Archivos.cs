
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializable.Controller
{
    class Archivos
    {
        private Stream stream;
        private BinaryFormatter Formateador = new BinaryFormatter();

        public bool Serializar(object Equipo)
        {
            stream = new FileStream("Equipos.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            Formateador.Serialize(stream, Equipo);
            stream.Close();
            return true;
        }

        public object Deserializar()
        {
            object v = null;
            stream = new FileStream("Equipos.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            if (stream.Length > 0)
                v = Formateador.Deserialize(stream);
            stream.Close();
            return v;
        }
    }
}
