using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Data.DataModels
{
    public class Responsables
    {
        public int ResponsableId { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        public string? DocumentoIdentidad { get; set; }
    }
}
