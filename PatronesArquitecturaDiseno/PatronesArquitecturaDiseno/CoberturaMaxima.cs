using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public class CoberturaMaxima : Cobertura
    {
        public override decimal CalcularCosto()
        {
            decimal totalEnfermedades = 0;
            foreach (Enfermedad enfermedad in ListaEnfermedades)
            {
                totalEnfermedades += enfermedad.Costo;
            }
            return totalEnfermedades;
        }
    }
}
