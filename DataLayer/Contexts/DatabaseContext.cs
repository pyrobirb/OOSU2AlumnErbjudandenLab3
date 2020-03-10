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
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AlumnErbjudanden;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;");
            
            //Skolans ConnectionString
            //optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;Database=osu2015;user id=osu2015;password=wb9896;");
            base.OnConfiguring(optionsBuilder);
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AlumnProgram
            modelBuilder.Entity<AlumnProgramDto>()
                .HasKey(a => new { a.AlumnID, a.ProgramID });

            modelBuilder.Entity<AlumnProgramDto>()
                .HasOne(ap => ap.Alumn)
                .WithMany(a => a.AlumnProgram)
                .HasForeignKey(ap => ap.AlumnID);

            modelBuilder.Entity<AlumnProgramDto>()
                .HasOne(ap => ap.Program)
                .WithMany(p => p.AlumnProgram)
                .HasForeignKey(ap => ap.ProgramID);


            //AlumnKompetens
            modelBuilder.Entity<AlumnKompetensDto>()
                .HasKey(a => new { a.AlumnID, a.KompetensID });

            modelBuilder.Entity<AlumnKompetensDto>()
                .HasOne(ak => ak.Alumn)
                .WithMany(a => a.AlumnKompetens)
                .HasForeignKey(ak => ak.AlumnID);

            modelBuilder.Entity<AlumnKompetensDto>()
                .HasOne(ak => ak.Kompetens)
                .WithMany(k => k.AlumnKompetens)
                .HasForeignKey(ak => ak.KompetensID);

            //InformationsutskickAlumn
            modelBuilder.Entity<InformationsutskickAlumnDto>()
                .HasKey(a => new { a.AlumnID, a.InformationsutskickID });

            modelBuilder.Entity<InformationsutskickAlumnDto>()
                .HasOne(ia => ia.Alumn)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.AlumnID);

            modelBuilder.Entity<InformationsutskickAlumnDto>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.InformationsutskickID);

            //PersonalInformationsutskick
            modelBuilder.Entity<PersonalInformationsutskickDto>()
                .HasKey(p => new { p.PersonalID, p.InformationsutskickID });

            modelBuilder.Entity<PersonalInformationsutskickDto>()
                .HasOne(pi => pi.Personal)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.PersonalID);

            modelBuilder.Entity<PersonalInformationsutskickDto>()
                .HasOne(pi => pi.Informationsutskick)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.InformationsutskickID);

            //InformationsutskickAktivitet
            modelBuilder.Entity<InformationsutskickAktivitetDto>()
                .HasKey(i => new { i.InformationsutskickID, i.AktivitetID });

            modelBuilder.Entity<InformationsutskickAktivitetDto>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(ia => ia.InformationsutskickID);

            modelBuilder.Entity<InformationsutskickAktivitetDto>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            //AlumnAktivitet
            modelBuilder.Entity<AlumnAktivitetBokningDto>()
                .HasKey(i => new { i.AlumnID, i.AktivitetID });

            modelBuilder.Entity<AlumnAktivitetBokningDto>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnAktivitetBokningDto>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            //AlumnMaillista
            modelBuilder.Entity<AlumnMaillistaDto>()
                .HasKey(i => new { i.AlumnID, i.MaillistaID });

            modelBuilder.Entity<AlumnMaillistaDto>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnMaillistor)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnMaillistaDto>()
                .HasOne(pi => pi.Maillista)
                .WithMany(i => i.AlumnMaillistor)
                .HasForeignKey(pi => pi.MaillistaID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AktivitetDto> Aktiviteter { get; set; }
        public DbSet<AlumnDto> Alumner { get; set; }
        public DbSet<InformationsutskickDto> Informationsutskick { get; set; }
        public DbSet<KompetensDto> Kompetenser { get; set; }
        public DbSet<PersonalDto> Personal { get; set; }
        public DbSet<ProgramDto> Program { get; set; }
        public DbSet<AlumnProgramDto> AlumnProgram { get; set; }
        public DbSet<AlumnKompetensDto> AlumnKompetens { get; set; }
        public DbSet<MaillistaDto> Maillistor { get; set; }
        public DbSet<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }
        public DbSet<PersonalInformationsutskickDto> PersonalInformationsutskick { get; set; }
        public DbSet<InformationsutskickAktivitetDto> InformationsutskickAktivitet { get; set; }
        public DbSet<AlumnAktivitetBokningDto> AlumnAktivitet { get; set; }
        public DbSet<AlumnMaillistaDto> AlumnMaillist { get; set; }




    }
}
