
using System;

namespace Serializable.Model
{
    [Serializable]
    class Equipo
    {
        public string Nombre { get; set; }
        public string Estadio { get; set; }
        public Uri uEstadio { get; set; }
        public Uri uEscudo { get; set; }

        public Equipo(string sNombre, string sEstadio, Uri uEstadio, Uri uEscudo)
        {
            this.Nombre = sNombre;
            this.Estadio = sEstadio;
            this.uEstadio = uEstadio;
            this.uEscudo = uEscudo;
        }
    }
}
