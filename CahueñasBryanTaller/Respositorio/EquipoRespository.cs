using CahueñasBryanTaller.Models;

namespace CahueñasBryanTaller.Respositorio
{
    public class EquipoRespository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipo()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 10,
                PartidosPerdidos = 10,

            };
            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 9,
                PartidosEmpatados = 5,
                PartidosPerdidos = 10,

            };
            equipos.Add(ldu);
            equipos.Add(barcelona);

            return equipos;
        }
    }
} 