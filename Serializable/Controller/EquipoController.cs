
using Serializable.Model;
using System.Collections.Generic;

namespace Serializable.Controller
{
    class EquipoController
    {
        public List<Equipo> Equipos { get; set; }

        public EquipoController()
        {
            Equipos = new List<Equipo>();
        }

        public void Create(Equipo Equipo)
        {
            Equipos.Add(Equipo);
        }

        public List<Equipo> Read(string Filter)
        {
            List<Equipo> Read = new List<Equipo>();
            foreach (Equipo Equipo in Equipos)
            {
                if (Equipo.Nombre.Contains(Filter))
                {
                    Read.Add(Equipo);
                }
            }
            return Read;
        }

        public void Update(int Index, Equipo Equipo)
        {
            Equipos.Insert(Index, Equipo);
        }

        public void Delete(int Index)
        {
            Equipos.RemoveAt(Index);
        }

    }
}
