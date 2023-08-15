using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Rutas
    {
        public int RutaId { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public string? Tiempo { get; set; }
        public string? Distancia { get; set; }
    }
}
