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

        DbSet<AktivitetDto> Aktiviteter { get; set; }
        DbSet<AlumnDto> Alumner { get; set; }
        DbSet<InformationsutskickDto> Informationsutskick { get; set; }
        DbSet<KompetensDto> Kompetenser { get; set; }
        DbSet<PersonalDto> Personal { get; set; }
        DbSet<ProgramDto> Program { get; set; }
        DbSet<AlumnProgramDto> AlumnProgram { get; set; }
        DbSet<AlumnKompetensDto> AlumnKompetens { get; set; }
        DbSet<MaillistaDto> Maillistor { get; set; }
        DbSet<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }
        DbSet<PersonalInformationsutskickDto> PersonalInformationsutskick { get; set; }
        DbSet<InformationsutskickAktivitetDto> InformationsutskickAktivitet { get; set; }
        DbSet<AlumnAktivitetBokningDto> AlumnAktivitet { get; set; }
        DbSet<AlumnMaillistaDto> AlumnMaillist { get; set; }
    }
}
