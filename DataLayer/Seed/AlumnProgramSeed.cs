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
            Alumn alumn1 = new Alumn()
            {
                Användarnamn = "Vims@gmail.com",
                Lösenord = "smiv",
                Förnamn = "Vissla",
                Efternamn = "Kvist",


            };

            infoutskickContext.Alumner.Add(alumn1);

            //infoutskickContext.Alumner.Add(alumn1);

            Program program1 = new Program()
            {
                Namn = "Systemarkitekt"

            };

            infoutskickContext.Program.Add(program1);

            infoutskickContext.AlumnProgram.Add(new AlumnProgram()
            {
                Alumn = alumn1,
                Program = program1
            });

            //infoutskickContext.AlumnProgram.Add(alumnProgram1);

            //infoutskickContext.AlumnPro.Add();

            infoutskickContext.SaveChanges();

        }


    }
}
