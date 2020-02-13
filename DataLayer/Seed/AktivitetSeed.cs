using BusinessEntites.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seed
{
    public class AktivitetSeed
    {
        public static void Populate(InfoutskickContext infoutskickContext)
        {
            infoutskickContext.Aktiviteter.Add(new Aktivitet()
            {
                AktivitetsID = "001",


            });
        }
    }
}
