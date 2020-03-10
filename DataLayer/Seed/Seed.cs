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
                AlumnDTO alumn1 = new AlumnDTO()
                {
                    Användarnamn = "abc",
                    Lösenord = "123",
                    Förnamn = "Vissla",
                    Efternamn = "Kvist",
                };
                dbContext.Alumner.Add(alumn1);

                AlumnDTO alumn2 = new AlumnDTO()
                {
                    Användarnamn = "Palle@mail.com",
                    Lösenord = "123",
                    Förnamn = "Palle",
                    Efternamn = "Kuling",
                };
                dbContext.Alumner.Add(alumn2);

                AlumnDTO alumn3 = new AlumnDTO()
                {
                    Användarnamn = "Banan@mail.com",
                    Lösenord = "123",
                    Förnamn = "Jan",
                    Efternamn = "Banan",
                };
                dbContext.Alumner.Add(alumn3);

                AlumnDTO alumn4 = new AlumnDTO()
                {
                    Användarnamn = "Tony@mail.com",
                    Lösenord = "123",
                    Förnamn = "Tony",
                    Efternamn = "Stark",
                };
                dbContext.Alumner.Add(alumn4);

                //Program
                ProgramDTO program0 = new ProgramDTO()
                {
                    Namn = "Alla"
                };
                dbContext.Program.Add(program0);

                ProgramDTO program1 = new ProgramDTO()
                {
                    Namn = "Systemarkitekt"
                };
                dbContext.Program.Add(program1);

                ProgramDTO program2 = new ProgramDTO()
                {
                    Namn = "Systemvetare"
                };
                dbContext.Program.Add(program2);

                ProgramDTO program3 = new ProgramDTO()
                {
                    Namn = "Dataekonom"
                };
                dbContext.Program.Add(program3);

                dbContext.AlumnProgram.Add(new AlumnProgramDTO()
                {
                    Alumn = alumn1,
                    Program = program1
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDTO()
                {
                    Alumn = alumn2,
                    Program = program2
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDTO()
                {
                    Alumn = alumn3,
                    Program = program3
                });

                dbContext.AlumnProgram.Add(new AlumnProgramDTO()
                {
                    Alumn = alumn4,
                    Program = program2
                });


                //Kompetens
                KompetensDTO kompetens1 = new KompetensDTO()
                {
                    Beskrivning = "Har 3 års erfarenhet som utvecklare i C#"
                };

                dbContext.AlumnKompetens.Add(new AlumnKompetensDTO()
                {
                    Alumn = alumn1,
                    Kompetens = kompetens1
                });
                //Personal
                PersonalDTO personal = new PersonalDTO()
                {
                    Användarnamn = "SuperAdmin",
                    Lösenord = "123",
                    Förnamn = "Super",
                    Efternamn = "Admin",
                };
                dbContext.Personal.Add(personal);

                PersonalDTO personal1 = new PersonalDTO()
                {
                    Användarnamn = "P5500",
                    Lösenord = "pers",
                    Förnamn = "Jan",
                    Efternamn = "Andersson",
                };
                dbContext.Personal.Add(personal1);

                //Aktivitet
                AktivitetDTO aktivitet1 = new AktivitetDTO()
                {
                    Titel = "Företagsmässa för nyexaminerade",
                    Ansvarig = "Milla Trop",
                    Kontaktperson = "Loki Foi",
                    Plats = "Högskolan i Borås",
                    Startdatum = new DateTime(2020, 08, 01),
                    Slutdatum = new DateTime(2020, 08, 02),
                    Beskrivning = "Träffa företag som är i behov av just dig! Knyt kontakter och maxa dina möjligheter",
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitetDTO>(),
                    AlumnAktivitet = new List<AlumnAktivitetBokningDTO>()
                };
                dbContext.Aktiviteter.Add(aktivitet1);

                AktivitetDTO aktivitet2 = new AktivitetDTO()
                {
                    Titel = "Föreläsning av Elon Musk",
                    Ansvarig = "Henry Jons",
                    Kontaktperson = "Jocke Boi",
                    Plats = "Högskolan i Borås, Sparbankssalen",
                    Startdatum = new DateTime(2020, 09, 01),
                    Slutdatum = new DateTime(2020, 09, 02),
                    Beskrivning = "Elon Musk kommer och berättar om sin spännande resa från ung entreprenör i Sydafrika till en av världens mest kända företagsledare.",
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitetDTO>(),
                    AlumnAktivitet = new List<AlumnAktivitetBokningDTO>()
                };
                dbContext.Aktiviteter.Add(aktivitet2);

                dbContext.SaveChanges();
            }

        }


    }
}
