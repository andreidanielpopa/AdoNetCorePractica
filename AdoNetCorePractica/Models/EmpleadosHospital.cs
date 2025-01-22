using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Models
{
    public class EmpleadosHospital
    {
        public List<Empleados> DatosEmpleados { get; set; } 
        public string SumaSalarial { get; set; }
        public string MediaSalarial { get; set; }
        public string Personas { get; set; }
    }
}
