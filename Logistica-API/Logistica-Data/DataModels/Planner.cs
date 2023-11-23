using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Planner
    {
        private string? Placa { get; set; }
        private string? Arrastre { get; set; }
        private string? Cliente { get; set; }
        private string? Oigen { get; set; }
        private string? Destino { get; set; }
        private string? Indicacion { get; set; }
        private object? Inicio { get; set; }
        private string? Conductor { get; set; }
        private int? Duracion { get; set; }
        private DateTime? Fin { get; set; }
        private string? Estatus { get; set; }
        private DateTime? DateCreated { get; set; }
    }
}
