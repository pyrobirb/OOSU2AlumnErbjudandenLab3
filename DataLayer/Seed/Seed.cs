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
            if (dbContext.Alumner.Count() == 0)
            {



                //Alumn
                AlumnDto alumn1 = new AlumnDto()
                {
                    Användarnamn = "abc",
                    Lösenord = "123",
                    Förnamn = "Vissla",
                    Efternamn = "Kvist",
                };
                dbContext.Alumner.Add(alumn1);

                AlumnDto alumn2 = new AlumnDto()
                {
                    Användarnamn = "Palle@mail.com",
                    Lösenord = "123",
                    Förnamn = "Palle",
                    Efternamn = "Kuling",
                };
                dbContext.Alumner.Add(alumn2);

                AlumnDto alumn3 = new AlumnDto()
                {
                    Användarnamn = "Banan@mail.com",
                    Lösenord = "123",
                    Förnamn = "Jan",
                    Efternamn = "Banan",
                };
                dbContext.Alumner.Add(alumn3);

                AlumnDto alumn4 = new AlumnDto()
                {
                    Användarnamn = "Tony@mail.com",
                    Lösenord = "123",
                    Förnamn = "Tony",
                    Efternamn = "Stark",
                };
                dbContext.Alumner.Add(alumn4);

                //Program
                ProgramDto program0 = new ProgramDto()
                {
                    Namn = "Alla"
                };
                dbContext.Program.Add(program0);

                ProgramDto program1 = new ProgramDto()
                {
                    Namn = "Systemarkitekt"
                };
                dbContext.Program.Add(program1);

                ProgramDto program2 = new ProgramDto()
                {
                    Namn = "Systemvetare"
                };
                dbContext.Program.Add(program2);

                ProgramDto program3 = new ProgramDto()
                {
                    Namn = "Dataekonom"
                };
                dbContext.Program.Add(program3);

                dbContext.AlumnProgram.Add(new AlumnProgramDto()
                {
                    Alumn = alumn1,
                    Program = program1
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDto()
                {
                    Alumn = alumn2,
                    Program = program2
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDto()
                {
                    Alumn = alumn3,
                    Program = program3
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDto()
                {
                    Alumn = alumn4,
                    Program = program2
                });


                //Kompetens
                KompetensDto kompetens1 = new KompetensDto()
                {
                    Beskrivning = "Har 3 års erfarenhet som utvecklare i C#"
                };

                dbContext.AlumnKompetens.Add(new AlumnKompetensDto()
                {
                    Alumn = alumn1,
                    Kompetens = kompetens1
                });
                //Personal
                PersonalDto personal = new PersonalDto()
                {
                    Användarnamn = "SuperAdmin",
                    Lösenord = "123",
                    Förnamn = "Super",
                    Efternamn = "Admin",
                };
                dbContext.Personal.Add(personal);

                PersonalDto personal1 = new PersonalDto()
                {
                    Användarnamn = "P5500",
                    Lösenord = "pers",
                    Förnamn = "Jan",
                    Efternamn = "Andersson",
                };
                dbContext.Personal.Add(personal1);

                //Aktivitet
                AktivitetDto aktivitet1 = new AktivitetDto()
                {
                    Titel = "Företagsmässa för nyexaminerade",
                    Ansvarig = "Milla Trop",
                    Kontaktperson = "Loki Foi",
                    Plats = "Högskolan i Borås",
                    Startdatum = new DateTime(2020, 08, 01),
                    Slutdatum = new DateTime(2020, 08, 02),
                    Beskrivning = "Träffa företag som är i behov av just dig! Knyt kontakter och maxa dina möjligheter",
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitetDto>(),
                    AlumnAktivitet = new List<AlumnAktivitetBokningDto>()
                };
                dbContext.Aktiviteter.Add(aktivitet1);

                AktivitetDto aktivitet2 = new AktivitetDto()
                {
                    Titel = "Föreläsning av Elon Musk",
                    Ansvarig = "Henry Jons",
                    Kontaktperson = "Jocke Boi",
                    Plats = "Högskolan i Borås, Sparbankssalen",
                    Startdatum = new DateTime(2020, 09, 01),
                    Slutdatum = new DateTime(2020, 09, 02),
                    Beskrivning = "Elon Musk kommer och berättar om sin spännande resa från ung entreprenör i Sydafrika till en av världens mest kända företagsledare.",
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitetDto>(),
                    AlumnAktivitet = new List<AlumnAktivitetBokningDto>()
                };
                dbContext.Aktiviteter.Add(aktivitet2);

                dbContext.SaveChanges();
            }

        }


    }
}
