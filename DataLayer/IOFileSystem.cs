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
        public void SkrivaAlumnAktivitetTillCSVFil(string Aktivitettitel, List<AlumnDto> alumner)
        {
            using (TextWriter sw = new StreamWriter($"{Aktivitettitel}.csv"))
            {

                sw.WriteLine(Aktivitettitel);

                foreach (AlumnDto alumn in alumner)
                {
                    sw.WriteLine($"{alumn.Användarnamn},");
                }
                sw.Close();
            }
        }
    }
}
