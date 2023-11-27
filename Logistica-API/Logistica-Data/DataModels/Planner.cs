using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Planner : TableEntity
    {
        public string? Placa { get; set; }
        public string? Arrastre { get; set; }
        public string? Cliente { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public string? Indicacion { get; set; }
        public DateTime? Inicio { get; set; }
        public string? Conductor { get; set; }
        public string? Duracion { get; set; }
        public DateTime? Fin { get; set; }
        public string? Estatus { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
