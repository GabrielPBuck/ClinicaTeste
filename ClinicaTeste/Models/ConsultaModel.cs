using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaTeste.Models
{
    public class ConsultaModel : Paciente
    {
        [Key]
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public string DataConsulta { get; set; }        
        public string FichaMedica { get; set; }
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
    }
}
