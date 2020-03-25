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
using ProgramClass = BusinessEntites.Models.ProgramDTO;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
        public IOFileSystem iof = new IOFileSystem();
        DatabaseContext dbContext = new DatabaseContext();


        public IEnumerable<AktivitetDTO> HämtaAllaAktiviteter()
        {
            return unitOfWork.AktivitetRepository.GetAll();
        }

        public AlumnDTO HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.AlumnRepository.HämtaAlumnKonto(användarnamn, lösenord);
        }

        public List<AktivitetDTO> HämtaAktiviteterGenomAktivitetID(IQueryable<int> ids)
        {
            List<AktivitetDTO> aktiviteter = new List<AktivitetDTO>();
            foreach (int id in ids)
            {
                aktiviteter.Add(unitOfWork.AktivitetRepository.GetById(id));
            }
            return aktiviteter;
           
        }

        public List<AlumnDTO> HämtaAnmälningarGenomAktivitetsID(int aktivitetsID)
        {
            List<AlumnDTO> AnmäldaAlumner = new List<AlumnDTO>();
            List<int> UtskicksID = new List<int>();
            List<int> AnmäldaAlumnerID = new List<int>();

            //Hämtar alla alumner som har bokat aktivitet
            IQueryable<AlumnAktivitetBokningDTO> alumnAktivitetBoknings = unitOfWork.AktivitetRepository.HämtaAlumnGenomAktivitetsID(aktivitetsID);
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

        public IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDTO inloggadAlumn)
        {
            return unitOfWork.AktivitetRepository.HämtaAktiviteterGenomAlumn(inloggadAlumn);
        }

        public PersonalDTO HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.PersonalRepository.HämtaPersonalKonto(användarnamn, lösenord);
        }

        public void UpdateAktivitet(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet)
        {
            unitOfWork.AktivitetRepository.UpdateAktivitet(aktivitet, nyaktivitet);
        }

        public void SparaBokadAktivitet(AlumnAktivitetBokningDTO alumnAktivitetBokningDTO)
        {
            //throw new NotImplementedException();
            dbContext.AlumnAktivitet.Add(alumnAktivitetBokningDTO);
            dbContext.SaveChanges();
        }

        public void UpdateAktivitetWPF(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet)
        {
            unitOfWork.AktivitetRepository.UpdateAktivitetWPF(aktivitet, nyaktivitet);
        }
        public IEnumerable<InformationsutskickDTO> HämtaAllaInformationsutskick()
        {
            return unitOfWork.InformationsutskickRepository.GetAll();
        }

        public List<AktivitetDTO> HämtaAktiviteterGenomInformationsutskickID(IQueryable<int> utskicksID)
        {
            List<AktivitetDTO> aktiviteter = new List<AktivitetDTO>();
            foreach (int id in utskicksID)
            {
                aktiviteter.Add(unitOfWork.AktivitetRepository.HämtaAktivitetIDGenomInformationsutskicksID(id));
            }
            return aktiviteter;
        }

        public void TaBortProgram(ProgramClass programDTO)
        {
            unitOfWork.ProgramRepository.TaBortProgram(programDTO);
        }

        public IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDTO aktuellAlumn)
        {
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickAlumnGenomAlumnID(aktuellAlumn);
        }

        public IQueryable<int> HämtaInformationsutskickIDGenomAlumn(AlumnDTO aktuellAlumn)
        {
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickIDFörAlumn(aktuellAlumn);
        }

        public AlumnDTO HämtaAlumnMedID(int användarID)
        {
            return unitOfWork.AlumnRepository.GetById(användarID);

        }
        
        public AktivitetDTO HämtaAktivitetGenomID(int aktivitetID)
        {
            return unitOfWork.AktivitetRepository.GetById(aktivitetID);
        }

        public void LäggTillAlumn(AlumnDTO alumn)
        {
            unitOfWork.AlumnRepository.Add(alumn);
            unitOfWork.Commit();
        }

        public IQueryable<int> HämtaInformationsutskickFörAlumn(AlumnDTO inloggadAlumn)
        {   
            return unitOfWork.InformationsutskickRepository.HämtaInformationsutskickIDFörAlumn(inloggadAlumn);
        }

        public IEnumerable<AlumnDTO> HämtaAllaAlumner()
        {
            return unitOfWork.AlumnRepository.GetAll();
        }

        public void LäggTillPersonal(PersonalDTO personal)
        {
            unitOfWork.PersonalRepository.Add(personal);
            unitOfWork.Commit();
        }

        public List<KompetensDTO> HämtaKompetenserFörAlumn(AlumnDTO aktuellAlumn)
        {
            List<KompetensDTO> kompetenser = new List<KompetensDTO>();
            var queryable = unitOfWork.KompetensRepository.HämtaKompetenserFörAlumn(aktuellAlumn);

            foreach (KompetensDTO kompetens in queryable)
            {
                kompetenser.Add(kompetens);
            }
            return kompetenser;
        }

        public IEnumerable<ProgramClass> HämtaAllaProgram()
        {
            return unitOfWork.ProgramRepository.GetAll();
        }

        public List<ProgramClass> HämtaProgramFörAlumn(AlumnDTO aktuellAlumn)
        {
            List<ProgramClass> programs = new List<ProgramClass>();
            var queryable = unitOfWork.ProgramRepository.HämtaProgramFörAlumn(aktuellAlumn);

            foreach (ProgramClass program in queryable)
            {
                programs.Add(program);
            }
            return programs;
        }

        

        public IQueryable<AlumnAktivitetBokningDTO> HämtaBokningFörAlumn (AlumnDTO inloggadAlumn)
        {
            return unitOfWork.AktivitetRepository.HämtaBokningFörAlumn(inloggadAlumn);
        }

        public void Commit()
        {
            unitOfWork.Commit();
        }

        public void UppdateraAlumn(int id, string förnamn, string efternamn, string epostadress, string lösenord = null)
        {
            unitOfWork.AlumnRepository.UppdateraAlumnKonto(id, förnamn, efternamn, epostadress, lösenord);
        }

        public void LäggTillAktivitet(AktivitetDTO aktivitet)
        {
            unitOfWork.AktivitetRepository.Add(aktivitet);
            Commit();
        }

        public List<AlumnDTO> HämtaAlumnerMedProgram(ProgramDTO program)
        {
            List<AlumnDTO> alumnerMedProgram = new List<AlumnDTO>();
            foreach (AlumnProgramDTO ap in unitOfWork.AlumnRepository.HämtaAlumnerMedProgram(program))
            {
                alumnerMedProgram.Add(unitOfWork.AlumnRepository.GetById(ap.AlumnID));
            }
            return alumnerMedProgram;
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            unitOfWork.ProgramRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        public void LäggTillAlumnAktivitet(AlumnAktivitetBokningDTO alumnAktivitetBokning)
        {
            unitOfWork.AktivitetRepository.LäggTillAlumnAktivitetBokning(alumnAktivitetBokning);
        }

        public void LäggTillKompetensTillAlumn(int id, string text)
        {
            unitOfWork.KompetensRepository.LäggTillUtbildningTillAlumn(id, text);
        }

        
        public void TaBortProgramFrånAlumn(ProgramClass selectedProgramToRemove, AlumnDTO aktuellAlumn)
        {
            unitOfWork.ProgramRepository.TaBortProgramFrånAlumn(selectedProgramToRemove, aktuellAlumn);
        }

        public void TaBortKompetensFrånAlumn(KompetensDTO selectedKompetensToRemove, AlumnDTO aktuellAlumn)
        {
            unitOfWork.KompetensRepository.TaBortKompetensFrånAlumn(selectedKompetensToRemove, aktuellAlumn);
        }

        public void TaBortAktivitetFrånAlumn(AktivitetDTO aktivitet, AlumnDTO aktuellAlumn)
        {
            unitOfWork.AktivitetRepository.TaBortAktivitetFrånAlumn(aktivitet, aktuellAlumn);
        }

        public void LäggTillInformationsutskick(InformationsutskickDTO informationsutskick)
        {
            unitOfWork.InformationsutskickRepository.Add(informationsutskick);
        }

        public void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDTO informationsutskickAktivitet)
        {
            unitOfWork.InformationsutskickRepository.LäggTillInformationsutskickAktivitet(informationsutskickAktivitet);
        }

        public InformationsutskickDTO HämtaInformationsutskickMedID(int utskicksID)
        {
            return unitOfWork.InformationsutskickRepository.GetById(utskicksID);
        }

        public void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDTO informationsutskickAlumn)
        {
            unitOfWork.InformationsutskickRepository.LäggTillInformationsutskickAlumn(informationsutskickAlumn);
            unitOfWork.Commit();
        }

        public void SkrivaAlumnAktivitetTillCSVFil(string titel, List<AlumnDTO> alumner)
        {
            iof.SkrivaAlumnAktivitetTillCSVFil(titel, alumner);
        }

        public void TaBortAlumn(AlumnDTO alumnatttabort)
        {
            unitOfWork.AlumnRepository.Remove(alumnatttabort);
            unitOfWork.Commit();
        }

        public List<AlumnDTO> HämtaAlumnerFrånLista(int ListID)
        {
            IQueryable<InformationsutskickAlumnDTO> hämtadeAlumnID = unitOfWork.InformationsutskickRepository.HämtaAlumnIdGenomUtskicksId(ListID);
            List<AlumnDTO> AlumnerAttSkicka = new List<AlumnDTO>();
            foreach (InformationsutskickAlumnDTO A in hämtadeAlumnID)
            {
                AlumnerAttSkicka.Add(HämtaAlumnMedID(A.AlumnID));               
            }

            return AlumnerAttSkicka;
        }

        public void LäggTillMaillista(MaillistaDTO maillista)
        {
            unitOfWork.MaillistaRepository.Add(maillista);
        }

        public MaillistaDTO HämtaSenasteMaillista()
        {
            return unitOfWork.MaillistaRepository.GetLastList();
        }

        public void LäggTillAlumnMaillista(AlumnMaillistaDTO alumnMaillista)
        {
            unitOfWork.AlumnRepository.LäggTillAlumnMaillista(alumnMaillista);
        }

        public IEnumerable<MaillistaDTO> HämtaAllaMaillistor()
        {
            return unitOfWork.MaillistaRepository.GetAll();
        }

        public List<AlumnDTO> HämtaAlumnerFrånMailLista(int maillistaID)
        {
            IQueryable<AlumnMaillistaDTO> hämtadeAlumnID = unitOfWork.MaillistaRepository.HämtaAlumnIdGenomMaillistaID(maillistaID);
            List<AlumnDTO> AlumnerAttSkicka = new List<AlumnDTO>();
            foreach (AlumnMaillistaDTO A in hämtadeAlumnID)
            {
                AlumnerAttSkicka.Add(HämtaAlumnMedID(A.AlumnID));
            }

            return AlumnerAttSkicka;
        }
    }
}
