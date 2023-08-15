using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Vehiculos
    {
        public int VehiculoId { get; set; }
        public string? Placa { get; set; }
        public string? Marca { get; set; }
        public string? Peso { get; set; }
        public string? Tipo { get; set; }
        public string? Cantidad { get; set; }
    }
}
