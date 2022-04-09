using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public class MainCentroSalud
    {
        List<Persona> Clientes = new List<Persona>();
        List<Enfermedad> Enfermedades = new List<Enfermedad>();
        List<Atencion> Atenciones = new List<Atencion>();
        public decimal CargarAtencion(int dniPersona, int codigoEnfermedad, Cobertura coberturaSeleccionada, DateTime fechaSolicitud)
        {
            Persona persona = (Persona)Clientes.Where(x => x.DNI==dniPersona);
            Enfermedad enfermedad = (Enfermedad)Enfermedades.Where(x => x.Codigo == codigoEnfermedad);
            if (persona.CapacidadDECobertura(coberturaSeleccionada)==false)
                return 0;
            if(coberturaSeleccionada.VerificarCoberturaEnfermedad(codigoEnfermedad))
            {
                Atencion atencion = new Atencion(Atenciones.Count, fechaSolicitud, enfermedad, persona);
                return enfermedad.Costo;
            }
            return 0;
        }
    }
}
