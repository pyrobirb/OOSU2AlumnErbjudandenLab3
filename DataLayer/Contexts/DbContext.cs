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
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AlumnErbjudanden;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AlumnKompetens
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


    }
}
