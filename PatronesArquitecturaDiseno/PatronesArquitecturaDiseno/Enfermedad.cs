using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public class Enfermedad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public TiposEnfermedad Tipo { get; set; }
    }
}
