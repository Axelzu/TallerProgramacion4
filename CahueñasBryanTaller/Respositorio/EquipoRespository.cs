using CahueñasBryanTaller.Models;

namespace CahueñasBryanTaller.Repositorio
{
    public class EquipoRespository
    {
        public List<Equipo> Equipos;

        public EquipoRespository()
        {
            Equipos = DevuelveListadoEquipo();
        }

        private List<Equipo> DevuelveListadoEquipo()
        {
            return new List<Equipo>
            {
                new Equipo
                {
                    Id = 1,
                    Nombre = "Liga de Quito",
                    PartidosJugados = 10,
                    PartidosGanados = 6,
                    PartidosEmpatados = 3,
                    PartidosPerdidos = 1
                },
                new Equipo
                {
                    Id = 2,
                    Nombre = "Barcelona",
                    PartidosJugados = 10,
                    PartidosGanados = 5,
                    PartidosEmpatados = 4,
                    PartidosPerdidos = 1
                }
            };
        }

        public IEnumerable<Equipo> ObtenerTodos()
        {
            return Equipos.OrderByDescending(e => e.PartidosGanados).ToList();
        }

        public Equipo DevuelveEquipoPorID(int id)
        {
            return Equipos.FirstOrDefault(e => e.Id == id);
        }

        public void AgregarEquipo(Equipo equipo)
        {
            equipo.Id = Equipos.Max(e => e.Id) + 1;
            Equipos.Add(equipo);
        }

        public bool ActualizarEquipo(int id, Equipo actualizado)
        {
            var equipo = Equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                equipo.Nombre = actualizado.Nombre;
                equipo.PartidosJugados = actualizado.PartidosJugados;
                equipo.PartidosGanados = actualizado.PartidosGanados;
                equipo.PartidosEmpatados = actualizado.PartidosEmpatados;
                equipo.PartidosPerdidos = actualizado.PartidosPerdidos;
                return true;
            }
            return false;
        }

        public void EliminarEquipo(int id)
        {
            var equipo = Equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                Equipos.Remove(equipo);
            }
        }
    }
}
