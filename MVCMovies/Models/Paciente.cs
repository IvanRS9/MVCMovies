using System.ComponentModel;

namespace MVCMovies.Models
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Sexo")]
        public string sexo { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateTime fechaNacimiento { get; set; }
        [DisplayName("Correo Electrónico")]
        public string email { get; set; }
        [DisplayName("Peso")]
        public double peso { get; set; }
        [DisplayName("Estatura")]
        public double estatura { get; set; }
    }
}
