using System;
namespace Hospitalizacion.Dominio{
    public class Paciente:Persona{
        public string Direccion{get;set;}
        public float Latitud{get;set;}
        public float Longitud{get;set;}
        public string Ciudad{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public FamiliarDesignado Familiar{get;set;}
        public Enfermera Enfermera{get;set;}
        public Medico Medico{get;set;}
        public Hisotria Historia{get;set;}
        public System.Collections.Generic.List<SignoVital> SignosVitales{get;set;}
    }
}