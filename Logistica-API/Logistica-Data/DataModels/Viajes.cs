using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Viajes 
    {
        public int ViajeId { get; set; }
        public DateTime? FechaCargue { get; set; }
        public DateTime? FechaDescargue { get; set; }
        public string? Caracteristicas { get; set; }
        public string? Cliente { get; set; }
        public Vehiculos? Vehiculo { get; set; } = new Vehiculos();
        public Rutas? Ruta { get; set; }
        public Responsables? Responsable { get; set; }
    }
}
