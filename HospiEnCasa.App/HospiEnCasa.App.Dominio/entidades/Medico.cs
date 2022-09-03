namespace HospiEnCasa.App.Dominio{
    public class Medico : Persona{
        /// Nombre de la especialidad medica del Médico  
        public string Especialidad { get; set; }
        /// Código único del médico
        public string Codigo { get; set; }
         /// Registro Unico Nacional del Talento Humano 
        public string RegistroRethus { get; set; }
    }
}