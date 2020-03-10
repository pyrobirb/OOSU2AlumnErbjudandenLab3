using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contexts
{
    public interface IDatabaseContext
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
        void OnModelCreating(ModelBuilder modelBuilder);

        DbSet<AktivitetDTO> Aktiviteter { get; set; }
        DbSet<AlumnDTO> Alumner { get; set; }
        DbSet<InformationsutskickDTO> Informationsutskick { get; set; }
        DbSet<KompetensDTO> Kompetenser { get; set; }
        DbSet<PersonalDTO> Personal { get; set; }
        DbSet<ProgramDTO> Program { get; set; }
        DbSet<AlumnProgramDTO> AlumnProgram { get; set; }
        DbSet<AlumnKompetensDTO> AlumnKompetens { get; set; }
        DbSet<MaillistaDTO> Maillistor { get; set; }
        DbSet<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        DbSet<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        DbSet<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        DbSet<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        DbSet<AlumnMaillistaDTO> AlumnMaillist { get; set; }
    }
}
