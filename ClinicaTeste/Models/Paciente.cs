using System.ComponentModel.DataAnnotations;

namespace ClinicaTeste.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
    }
}
