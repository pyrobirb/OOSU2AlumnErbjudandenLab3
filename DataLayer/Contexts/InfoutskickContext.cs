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
    public class InfoutskickContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AlumnErbjudanden;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnProgram>()
                .HasKey(t => new { t.AlumnID, t.ProgramID });

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Alumn)
                .WithMany(a => a.AlumnProgram)
                .HasForeignKey(ap => ap.AlumnID);

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Program)
                .WithMany(p => p.AlumnProgram)
                .HasForeignKey(ap => ap.ProgramID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aktivitet> Aktiviteter { get; set; }
        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Informationsutskick> Informationsutskick { get; set; }
        public DbSet<Kompetens> Kompetenser { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<AlumnProgram> AlumnProgram { get; set; }

    }
}
