using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class IOFileSystem : IIOFileSystem
    {
        public void SkrivaAlumnAktivitetTillCSVFil(string Aktivitettitel, List<Alumn> alumner)
        {
            using (TextWriter sw = new StreamWriter($"{Aktivitettitel}.csv"))
            {

                sw.WriteLine(Aktivitettitel);

                foreach (Alumn alumn in alumner)
                {
                    sw.WriteLine($"{alumn.Användarnamn},");
                }
                sw.Close();
            }
        }
    }
}
