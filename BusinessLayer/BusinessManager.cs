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
using ProgramClass = BusinessEntites.Models.ProgramDto;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
        public IOFileSystem iof = new IOFileSystem();

        
        public IEnumerable<AktivitetDto> HämtaAllaAktiviteter()
        {
            return unitOfWork.AktivitetRepository.GetAll();
        }

        public AlumnDto HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.AlumnRepository.HämtaAlumnKonto(användarnamn, lösenord);
        }

        public List<AktivitetDto> HämtaAktiviteterGenomAktivitetID(IQueryable<int> ids)
        {
            List<AktivitetDto> aktiviteter = new List<AktivitetDto>();
            foreach (int id in ids)
            {
                aktiviteter.Add(unitOfWork.AktivitetRepository.GetById(id));
            }
            return aktiviteter;
           
        }

        public List<AlumnDto> HämtaAnmälningarGenomAktivitetsID(int aktivitetsID)
        {
            List<AlumnDto> AnmäldaAlumner = new List<AlumnDto>();
            List<int> UtskicksID = new List<int>();
            List<int> AnmäldaAlumnerID = new List<int>();

            //Hämtar alla alumner som har bokat aktivitet
            IQueryable<AlumnAktivitetBokningDto> alumnAktivitetBoknings = unitOfWork.AktivitetRepository.HämtaAlumnGenomAktivitetsID(aktivitetsID);
            foreach (var item in alumnAktivitetBoknings)
            {
                AnmäldaAlumnerID.Add(item.AlumnID);
            }

            foreach (int id in AnmäldaAlumnerID)
            {
                AnmäldaAlumner.Add(unitOfWork.AlumnRepository.HämtaAlumnGenomID(id));
            }

            return AnmäldaAlumner;
        }

        public IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDto inloggadAlumn)
        {
            return unitOfWork.AktivitetRepository.HämtaAktiviteterGenomAlumn(inloggadAlumn);
        }

        public PersonalDto HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.PersonalRepository.HämtaPersonalKonto(användarnamn, lösenord);
        }
        public void UpdateAktivitet(AktivitetDto aktivitet, AktivitetDto nyaktivitet)
        {
            unitOfWork.AktivitetRepository.UpdateAktivitet(aktivitet, nyaktivitet);
        }


        public IEnumerable<InformationsutskickDto> HämtaAllaInformationsutskick()
        {
            return unitOfWork.InformationsutskickRepository.GetAll();
        }

        public List<AktivitetDto> HämtaAktiviteterGenomInformationsutskickID(IQueryable<int> utskicksID)
        {
            List<AktivitetDto> aktiviteter = new List<AktivitetDto>();
            foreach (int id in utskicksID)
            {
                aktiviteter.Add(unitOfWork.AktivitetRepository.HämtaAktivitetIDGenomInformationsutskicksID(id));
            }
            return aktiviteter;
        }



        public IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDto aktuellAlumn)
        {
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickAlumnGenomAlumnID(aktuellAlumn);
        }

        public IQueryable<int> HämtaInformationsutskickIDGenomAlumn(AlumnDto aktuellAlumn)
        {
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickIDFörAlumn(aktuellAlumn);
        }

        public AlumnDto HämtaAlumnMedID(int användarID)
        {
            return unitOfWork.AlumnRepository.GetById(användarID);

        }

        public AktivitetDto HämtaAktivitetGenomID(int aktivitetID)
        {
            return unitOfWork.AktivitetRepository.GetById(aktivitetID);
        }

        public void LäggTillAlumn(AlumnDto alumn)
        {
            unitOfWork.AlumnRepository.Add(alumn);
            unitOfWork.Commit();
        }

        public IQueryable<int> HämtaInformationsutskickFörAlumn(AlumnDto inloggadAlumn)
        {   
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickIDFörAlumn(inloggadAlumn);
        }

        public IEnumerable<AlumnDto> HämtaAllaAlumner()
        {
            return unitOfWork.AlumnRepository.GetAll();
        }

        public void LäggTillPersonal(PersonalDto personal)
        {
            unitOfWork.PersonalRepository.Add(personal);
            unitOfWork.Commit();
        }

        public List<KompetensDto> HämtaKompetenserFörAlumn(AlumnDto aktuellAlumn)
        {
            List<KompetensDto> kompetenser = new List<KompetensDto>();
            var queryable = unitOfWork.KompetensRepository.HämtaKompetenserFörAlumn(aktuellAlumn);

            foreach (KompetensDto kompetens in queryable)
            {
                kompetenser.Add(kompetens);
            }
            return kompetenser;
        }

        public IEnumerable<ProgramClass> HämtaAllaProgram()
        {
            return unitOfWork.ProgramRepository.GetAll();
        }

        public List<ProgramClass> HämtaProgramFörAlumn(AlumnDto aktuellAlumn)
        {
            List<ProgramClass> programs = new List<ProgramClass>();
            var queryable = unitOfWork.ProgramRepository.HämtaProgramFörAlumn(aktuellAlumn);

            foreach (ProgramClass program in queryable)
            {
                programs.Add(program);
            }
            return programs;
        }

        

        public IQueryable<AlumnAktivitetBokningDto> HämtaBokningFörAlumn (AlumnDto inloggadAlumn)
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

        public void LäggTillAktivitet(AktivitetDto aktivitet)
        {
            unitOfWork.AktivitetRepository.Add(aktivitet);
        }

        public List<AlumnDto> HämtaAlumnerMedProgram(ProgramDto program)
        {
            List<AlumnDto> alumnerMedProgram = new List<AlumnDto>();
            foreach (AlumnProgramDto ap in unitOfWork.AlumnRepository.HämtaAlumnerMedProgram(program))
            {
                alumnerMedProgram.Add(unitOfWork.AlumnRepository.GetById(ap.AlumnID));
            }
            return alumnerMedProgram;
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            unitOfWork.ProgramRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        public void LäggTillAlumnAktivitet(AlumnAktivitetBokningDto alumnAktivitetBokning)
        {
            unitOfWork.AktivitetRepository.LäggTillAlumnAktivitetBokning(alumnAktivitetBokning);
        }

        public void LäggTillKompetensTillAlumn(int id, string text)
        {
            unitOfWork.KompetensRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        
        public void TaBortProgramFrånAlumn(ProgramClass selectedProgramToRemove, AlumnDto aktuellAlumn)
        {
            unitOfWork.ProgramRepository.TaBortProgramFrånAlumn(selectedProgramToRemove, aktuellAlumn);
        }

        public void TaBortKompetensFrånAlumn(KompetensDto selectedKompetensToRemove, AlumnDto aktuellAlumn)
        {
            unitOfWork.KompetensRepository.TaBortKompetensFrånAlumn(selectedKompetensToRemove, aktuellAlumn);
        }

        public void TaBortAktivitetFrånAlumn(AktivitetDto aktivitet, AlumnDto aktuellAlumn)
        {
            unitOfWork.AktivitetRepository.TaBortAktivitetFrånAlumn(aktivitet, aktuellAlumn);
        }

        public void LäggTillInformationsutskick(InformationsutskickDto informationsutskick)
        {
            unitOfWork.InformationsutskickRepository.Add(informationsutskick);
        }

        public void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDto informationsutskickAktivitet)
        {
            unitOfWork.InformationsutskickRepository.LäggTillInformationsutskickAktivitet(informationsutskickAktivitet);
        }

        public InformationsutskickDto HämtaInformationsutskickMedID(int utskicksID)
        {
            return unitOfWork.InformationsutskickRepository.GetById(utskicksID);
        }

        public void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDto informationsutskickAlumn)
        {
            unitOfWork.InformationsutskickRepository.LäggTillInformationsutskickAlumn(informationsutskickAlumn);
        }

        public void SkrivaAlumnAktivitetTillCSVFil(string titel, List<AlumnDto> alumner)
        {
            iof.SkrivaAlumnAktivitetTillCSVFil(titel, alumner);
        }

        public void TaBortAlumn(AlumnDto alumnatttabort)
        {
            unitOfWork.AlumnRepository.Remove(alumnatttabort);
            unitOfWork.Commit();
        }

        public List<AlumnDto> HämtaAlumnerFrånLista(int ListID)
        {
            IQueryable<InformationsutskickAlumnDto> hämtadeAlumnID = unitOfWork.InformationsutskickRepository.HämtaAlumnIdGenomUtskicksId(ListID);
            List<AlumnDto> AlumnerAttSkicka = new List<AlumnDto>();
            foreach (InformationsutskickAlumnDto A in hämtadeAlumnID)
            {
                AlumnerAttSkicka.Add(HämtaAlumnMedID(A.AlumnID));               
            }

            return AlumnerAttSkicka;
        }

        public void LäggTillMaillista(MaillistaDto maillista)
        {
            unitOfWork.MaillistaRepository.Add(maillista);
        }

        public MaillistaDto HämtaSenasteMaillista()
        {
            return unitOfWork.MaillistaRepository.GetLastList();
        }

        public void LäggTillAlumnMaillista(AlumnMaillistaDto alumnMaillista)
        {
            unitOfWork.AlumnRepository.LäggTillAlumnMaillista(alumnMaillista);
        }

        public object HämtaAllaMaillistor()
        {
            return unitOfWork.MaillistaRepository.GetAll();
        }

        public List<AlumnDto> HämtaAlumnerFrånMailLista(int maillistaID)
        {
            IQueryable<AlumnMaillistaDto> hämtadeAlumnID = unitOfWork.MaillistaRepository.HämtaAlumnIdGenomMaillistaID(maillistaID);
            List<AlumnDto> AlumnerAttSkicka = new List<AlumnDto>();
            foreach (AlumnMaillistaDto A in hämtadeAlumnID)
            {
                AlumnerAttSkicka.Add(HämtaAlumnMedID(A.AlumnID));
            }

            return AlumnerAttSkicka;
        }
    }
}
