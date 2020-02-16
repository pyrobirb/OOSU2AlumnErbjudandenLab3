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
        public static void Populate(DbContext dbContext)
        {
            Alumn alumn1 = new Alumn()
            {
                Användarnamn = "Vims@gmail.com",
                Lösenord = "smiv",
                Förnamn = "Vissla",
                Efternamn = "Kvist",


            };

            dbContext.Alumner.Add(alumn1);

            //infoutskickContext.Alumner.Add(alumn1);

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



            dbContext.SaveChanges();

        }


    }
}
