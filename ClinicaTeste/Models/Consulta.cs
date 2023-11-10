using System.ComponentModel.DataAnnotations;

namespace ClinicaTeste.Models
{
    public class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public string DataConsulta { get; set; }        
        public string FichaMedica { get; set; }
    }
}

