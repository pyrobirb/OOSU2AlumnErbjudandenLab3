using BusinessEntites.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seed
{
    public class AlumnSeed
    {
        public static void Populate(InfoutskickContext infoutskickContext)
        {
            infoutskickContext.Alumner.Add(new Alumn()
            {
                Användarnamn = "Vims",
                Lösenord = "smiv",
                Förnamn = "Vissla",
                Efternamn = "Kvist"


    });
        }


    }
}
