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
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Lokal ConnectionString
            //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AlumnErbjudanden;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;");
            
            //Skolans ConnectionString
            optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;Database=osu2015;user id=osu2015;password=wb9896;");
            base.OnConfiguring(optionsBuilder);
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AlumnProgram
            modelBuilder.Entity<AlumnProgram>()
                .HasKey(a => new { a.AlumnID, a.ProgramID });

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Alumn)
                .WithMany(a => a.AlumnProgram)
                .HasForeignKey(ap => ap.AlumnID);

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Program)
                .WithMany(p => p.AlumnProgram)
                .HasForeignKey(ap => ap.ProgramID);


            //AlumnKompetens
            modelBuilder.Entity<AlumnKompetens>()
                .HasKey(a => new { a.AlumnID, a.KompetensID });

            modelBuilder.Entity<AlumnKompetens>()
                .HasOne(ak => ak.Alumn)
                .WithMany(a => a.AlumnKompetens)
                .HasForeignKey(ak => ak.AlumnID);

            modelBuilder.Entity<AlumnKompetens>()
                .HasOne(ak => ak.Kompetens)
                .WithMany(k => k.AlumnKompetens)
                .HasForeignKey(ak => ak.KompetensID);

            //InformationsutskickAlumn
            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasKey(a => new { a.AlumnID, a.InformationsutskickID });

            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasOne(ia => ia.Alumn)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.AlumnID);

            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.InformationsutskickID);

            //PersonalInformationsutskick
            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasKey(p => new { p.PersonalID, p.InformationsutskickID });

            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasOne(pi => pi.Personal)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.PersonalID);

            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasOne(pi => pi.Informationsutskick)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.InformationsutskickID);

            //InformationsutskickAktivitet
            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasKey(i => new { i.InformationsutskickID, i.AktivitetID });

            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(ia => ia.InformationsutskickID);

            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            //AlumnAktivitet
            modelBuilder.Entity<AlumnAktivitetBokning>()
                .HasKey(i => new { i.AlumnID, i.AktivitetID });

            modelBuilder.Entity<AlumnAktivitetBokning>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnAktivitetBokning>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aktivitet> Aktiviteter { get; set; }
        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Informationsutskick> Informationsutskick { get; set; }
        public DbSet<Kompetens> Kompetenser { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<AlumnProgram> AlumnProgram { get; set; }
        public DbSet<AlumnKompetens> AlumnKompetens { get; set; }
        public DbSet<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        public DbSet<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }
        public DbSet<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        public DbSet<AlumnAktivitetBokning> AlumnAktivitet { get; set; }




    }
}
