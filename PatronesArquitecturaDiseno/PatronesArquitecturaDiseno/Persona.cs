using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public class Persona
    {
        public int DNI { get; set; }
        public string NombreApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public decimal IngresosNetosAnuales { get; set; }

        public bool CapacidadDECobertura(Cobertura cobertura)
        {
            return cobertura.CalcularCosto()>IngresosNetosAnuales ? false : true;
        }
    }
}
