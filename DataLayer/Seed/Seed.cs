using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seed
{
    public class Seed
    {
        public static void Populate(DatabaseContext dbContext)
        {
            //Alumn
            Alumn alumn1 = new Alumn()
            {
                Användarnamn = "Vims@gmail.com",
                Lösenord = "smiv",
                Förnamn = "Vissla",
                Efternamn = "Kvist",


            };

            dbContext.Alumner.Add(alumn1);

            //Program
            Program program1 = new Program()
            {
                Namn = "Systemarkitekt"

            };

            dbContext.Program.Add(program1);

            dbContext.AlumnProgram.Add(new AlumnProgram()
            {
                Alumn = alumn1,
                Program = program1
            });
            //Kompetens
            Kompetens kompetens1 = new Kompetens()
            {
                Beskrivning = "Har 3 års erfarenhet som utvecklare i C#"
            };

            dbContext.AlumnKompetens.Add(new AlumnKompetens()
            {
                Alumn = alumn1,
                Kompetens = kompetens1
            });
            //Personal
            Personal personal1 = new Personal()
            {
                Användarnamn = "P5500",
                Lösenord = "pers",
                Förnamn = "Jan",
                Efternamn = "Andersson",
            };
            dbContext.Add(personal1);
            //Aktivitet
            Aktivitet aktivitet1 = new Aktivitet()
            {
                Titel = "Företagsmässa för nyexaminerade",
                Ansvarig = "Milla Trop",
                Kontaktperson = "Loki Foi",
                Plats = "Högskolan i Borås",
                Startdatum = new DateTime (2020, 08, 01),
                Slutdatum = new DateTime(2020, 08, 02),
                Beskrivning = "Träffa företag som är i behov av just dig! Knyt kontakter och maxa dina möjligheter",
                InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                AlumnAktivitet = new List<AlumnAktivitet>()
            };
            dbContext.Add(aktivitet1);

            dbContext.SaveChanges();

        }


    }
}
