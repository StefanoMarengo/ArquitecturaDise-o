using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesArquitecturaDiseno
{
    public abstract class Cobertura
    {
        //Clase con propiedad numero y dentro sobreescribimos el operador
        //divisor de esa clase, con el mismo tipo de datos de parametros
        //objetos de la misma clase
        //Clase1 num1 = new Clase1(){10}
        //El lista.Where() FILTRA
        //El lista.Select() Selecciona valores para poder modificar.- devuelve la lista completa
        //sirve para obtener una lista por ejemplo elevada a las 3.
        //Tambien seleccionar algunos generando una nueva instancia para
        //ser reasignada dsps
        //Lista.Select(x => new ClaseZ(x)) ---- var lista2 = new list<ClaseZ>
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int CantidadMaxFamiliar { get; set; }
        public decimal CostoBaseCobertura { get; set; }
        public List<Enfermedad> ListaEnfermedades { get; set; }
        public abstract decimal CalcularCosto();
        public bool VerificarCoberturaEnfermedad(int codigoEnfermedad)
        {
            if(ListaEnfermedades.Where(x=>x.Codigo==codigoEnfermedad)==null)
                return false;
            return true;
        }
    }
}
