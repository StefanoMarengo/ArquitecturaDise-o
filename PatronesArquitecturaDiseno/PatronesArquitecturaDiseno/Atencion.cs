using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public class Atencion
    {
        public int Nro { get; set; }
        public DateTime FechaAtencion { get; set; }
        public Enfermedad EnfermedadSolicitada { get; set; }
        public Persona Cliente { get; set; }
        public Atencion() { }
        public Atencion(int nro, DateTime fechaAtencion, Enfermedad enfermedadSolicitada, Persona cliente)
        {
            Nro = nro;
            FechaAtencion = fechaAtencion;
            EnfermedadSolicitada = enfermedadSolicitada;
            Cliente = cliente;
        }
    }
}
