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

        DbSet<Aktivitet> Aktiviteter { get; set; }
        DbSet<Alumn> Alumner { get; set; }
        DbSet<Informationsutskick> Informationsutskick { get; set; }
        DbSet<Kompetens> Kompetenser { get; set; }
        DbSet<Personal> Personal { get; set; }
        DbSet<Program> Program { get; set; }
        DbSet<AlumnProgram> AlumnProgram { get; set; }
        DbSet<AlumnKompetens> AlumnKompetens { get; set; }
        DbSet<Maillista> Maillistor { get; set; }
        DbSet<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        DbSet<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }
        DbSet<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        DbSet<AlumnAktivitetBokning> AlumnAktivitet { get; set; }
        DbSet<AlumnMaillista> AlumnMaillist { get; set; }
    }
}
