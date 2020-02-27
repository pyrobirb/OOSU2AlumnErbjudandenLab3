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
using ProgramClass = BusinessEntites.Models.Program;

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



        public List<Aktivitet> ListaAllaAktuellaAktiviteter()
        {
            List<Aktivitet> aktivitets = new List<Aktivitet>();
            IQueryable temp = unitOfWork.AktivitetRepository.HämtaAllaAktuellaAktiviteter();
            foreach (Aktivitet aktivitet in temp)
            {
                aktivitets.Add(aktivitet);
            }

            return aktivitets ;
        }

        public void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet)
        {
            unitOfWork.AktivitetRepository.UpdateAktivitet(aktivitet, nyaktivitet);
        }

        public Alumn HämtaAlumnMedID(int användarID)
        {
            return unitOfWork.AlumnRepository.GetById(användarID);

        }

        public IQueryable<InformationsutskickAlumn> HämtaInformationsutskickFörAlumn(Alumn inloggadAlumn)
        {   
            var b = unitOfWork.InformationsutskickRepository.HämtaInformationsutskickFörAlumn(inloggadAlumn);
            return b;
        }

        public List<Kompetens> HämtaKompetenserFörAlumn(Alumn aktuellAlumn)
        {
            List<Kompetens> kompetenser = new List<Kompetens>();
            var queryable = unitOfWork.KompetensRepository.HämtaKompetenserFörAlumn(aktuellAlumn);

            foreach (Kompetens kompetens in queryable)
            {
                kompetenser.Add(kompetens);
            }
            return kompetenser;
        }

        public void updateNewMessage(int id, bool v)
        {
            unitOfWork.AlumnRepository.UppdateNewMessage(id, v);
        }

        public List<ProgramClass> HämtaProgramFörAlumn(Alumn aktuellAlumn)
        {
            List<ProgramClass> programs = new List<ProgramClass>();
            var queryable = unitOfWork.ProgramRepository.HämtaProgramFörAlumn(aktuellAlumn);

            foreach (ProgramClass program in queryable)
            {
                programs.Add(program);
            }
            return programs;
        }

        public IQueryable<InformationsutskickAktivitet> HämtaAktivitetMedInformationsutskick (Informationsutskick informationsutskick)
        {
            return unitOfWork.AktivitetRepository.HämtaAktivitetMedInformationsutskick(informationsutskick);
            
        }

        public IQueryable<AlumnAktivitetBokning> HämtaBokningFörAlumn (Alumn inloggadAlumn)
        {
            return unitOfWork.AktivitetRepository.HämtaBokningFörAlumn(inloggadAlumn);
        }

        public void Commit()
        {
            unitOfWork.Commit();
        }

        public void UppdateraAlumn(int id, string förnamn, string efternamn, string epostadress)
        {
            unitOfWork.AlumnRepository.UppdateraAlumnKonto(id, förnamn, efternamn, epostadress);
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            unitOfWork.ProgramRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        public void LäggTillKompetensTillAlumn(int id, string text)
        {
            unitOfWork.KompetensRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        
        public void TaBortProgramFrånAlumn(ProgramClass selectedProgramToRemove, Alumn aktuellAlumn)
        {
            unitOfWork.ProgramRepository.TaBortProgramFrånAlumn(selectedProgramToRemove, aktuellAlumn);
        }

        public void TaBortKompetensFrånAlumn(Kompetens selectedKompetensToRemove, Alumn aktuellAlumn)
        {
            unitOfWork.KompetensRepository.TaBortKompetensFrånAlumn(selectedKompetensToRemove, aktuellAlumn);
        }
    }
}
