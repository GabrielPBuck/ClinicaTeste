using System.ComponentModel.DataAnnotations;

namespace ClinicaTeste.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        public string NomeMedico { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
    }
}
