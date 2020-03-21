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
            modelBuilder.Entity<AlumnProgramDTO>()
                .HasKey(a => new { a.AlumnID, a.ProgramID });

            modelBuilder.Entity<AlumnProgramDTO>()
                .HasOne(ap => ap.Alumn)
                .WithMany(a => a.AlumnProgram)
                .HasForeignKey(ap => ap.AlumnID);

            modelBuilder.Entity<AlumnProgramDTO>()
                .HasOne(ap => ap.Program)
                .WithMany(p => p.AlumnProgram)
                .HasForeignKey(ap => ap.ProgramID);


            //AlumnKompetens
            modelBuilder.Entity<AlumnKompetensDTO>()
                .HasKey(a => new { a.AlumnID, a.KompetensID });

            modelBuilder.Entity<AlumnKompetensDTO>()
                .HasOne(ak => ak.Alumn)
                .WithMany(a => a.AlumnKompetens)
                .HasForeignKey(ak => ak.AlumnID);

            modelBuilder.Entity<AlumnKompetensDTO>()
                .HasOne(ak => ak.Kompetens)
                .WithMany(k => k.AlumnKompetens)
                .HasForeignKey(ak => ak.KompetensID);

            //InformationsutskickAlumn
            modelBuilder.Entity<InformationsutskickAlumnDTO>()
                .HasKey(a => new { a.AlumnID, a.InformationsutskickID });

            modelBuilder.Entity<InformationsutskickAlumnDTO>()
                .HasOne(ia => ia.Alumn)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.AlumnID);

            modelBuilder.Entity<InformationsutskickAlumnDTO>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.InformationsutskickID);

            //PersonalInformationsutskick
            modelBuilder.Entity<PersonalInformationsutskickDTO>()
                .HasKey(p => new { p.PersonalID, p.InformationsutskickID });

            modelBuilder.Entity<PersonalInformationsutskickDTO>()
                .HasOne(pi => pi.Personal)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.PersonalID);

            modelBuilder.Entity<PersonalInformationsutskickDTO>()
                .HasOne(pi => pi.Informationsutskick)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.InformationsutskickID);

            //InformationsutskickAktivitet
            modelBuilder.Entity<InformationsutskickAktivitetDTO>()
                .HasKey(i => new { i.InformationsutskickID, i.AktivitetID });

            modelBuilder.Entity<InformationsutskickAktivitetDTO>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(ia => ia.InformationsutskickID);

            modelBuilder.Entity<InformationsutskickAktivitetDTO>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            //AlumnAktivitet
            modelBuilder.Entity<AlumnAktivitetBokningDTO>()
                .HasKey(i => new { i.AlumnID, i.AktivitetID });

            modelBuilder.Entity<AlumnAktivitetBokningDTO>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnAktivitetBokningDTO>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.AlumnAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            //AlumnMaillista
            modelBuilder.Entity<AlumnMaillistaDTO>()
                .HasKey(i => new { i.AlumnID, i.MaillistaID });

            modelBuilder.Entity<AlumnMaillistaDTO>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnMaillistor)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnMaillistaDTO>()
                .HasOne(pi => pi.Maillista)
                .WithMany(i => i.AlumnMaillistor)
                .HasForeignKey(pi => pi.MaillistaID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AktivitetDTO> Aktiviteter { get; set; }
        public DbSet<AlumnDTO> Alumner { get; set; }
        public DbSet<InformationsutskickDTO> Informationsutskick { get; set; }
        public DbSet<KompetensDTO> Kompetenser { get; set; }
        public DbSet<PersonalDTO> Personal { get; set; }
        public DbSet<ProgramDTO> Program { get; set; }
        public DbSet<AlumnProgramDTO> AlumnProgram { get; set; }
        public DbSet<AlumnKompetensDTO> AlumnKompetens { get; set; }
        public DbSet<MaillistaDTO> Maillistor { get; set; }
        public DbSet<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        public DbSet<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        public DbSet<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        public DbSet<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        public DbSet<AlumnMaillistaDTO> AlumnMaillist { get; set; }

    }
}
