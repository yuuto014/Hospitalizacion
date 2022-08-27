using System.Collections.Generic;

namespace Hospitalizacion.Dominio{
    public class Hisotria{
        public int Id{get;set;}
        public string Diacnostico{get;set;}
        public string Entorno{get;set;}
        public List<SugerenciaCuidado> Sugerencias{get;set;}
    }
}