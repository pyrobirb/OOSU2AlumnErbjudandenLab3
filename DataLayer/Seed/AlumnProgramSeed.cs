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
    public class AlumnProgramSeed
    {
        public static void Populate(InfoutskickContext infoutskickContext)
        {
            infoutskickContext.Alumner.Add(new Alumn()
            {
                Användarnamn = "Vims@gmail.com",
                Lösenord = "smiv",
                Förnamn = "Vissla",
                Efternamn = "Kvist",
                AlumnProgram = new List<AlumnProgram>()
                {
                    new AlumnProgram()
                    {
                        Namn = "Systemarkitekt"
                    }
                }

            });
            //infoutskickContext.Alumner.Add(alumn1);

            //Program program1 = new Program()
            //{
            //    Namn = "Systemarkitekt"

            //};



            //infoutskickContext.AlumnPro.Add();

            infoutskickContext.SaveChanges();

        }


    }
}
