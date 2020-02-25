using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.UnitOfWork;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());


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
        public Alumn HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.AlumnRepository.HämtaAlumnKonto(användarnamn, lösenord);
        }

        public Personal HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.PersonalRepository.HämtaPersonalKonto(användarnamn, lösenord);
        }
        public void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet)
        {
            unitOfWork.AktivitetRepository.UpdateAktivitet(aktivitet, nyaktivitet);
        }

        public IQueryable<Informationsutskick> HämtaInformationsutskickFörAlumn(Alumn inloggadAlumn)
        {   
            var b = unitOfWork.InformationsutskickRepository.HämtaInformationsutskickFörAlumn(inloggadAlumn);

            foreach (Alumn alumn in b)
            {

            }
            return b;
        }

        public void Commit()
        {
            unitOfWork.Commit();
        }
    }
}
