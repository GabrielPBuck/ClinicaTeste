using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicaTeste.Models;

namespace ClinicaTeste.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<ClinicaTeste.Models.Paciente> Paciente { get; set; } = default!;

        public DbSet<ClinicaTeste.Models.Consulta> Consulta { get; set; } = default!;

        public DbSet<ClinicaTeste.Models.Medico> Medico { get; set; } = default!;
    }
}
