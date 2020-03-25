using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramClass = BusinessEntites.Models.ProgramDTO;


namespace BusinessLayer
{
    public interface IBusinessManager
    {
        IEnumerable<AktivitetDTO> HämtaAllaAktiviteter();
        AlumnDTO HämtaAlumnKonto(string användarnamn, string lösenord);
        List<AktivitetDTO> HämtaAktiviteterGenomAktivitetID(IQueryable<int> ids);
        List<AlumnDTO> HämtaAnmälningarGenomAktivitetsID(int aktivitetsID);
        IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDTO inloggadAlumn);
        void UppdateraAlumn(int id, string förnamn, string efternamn, string epostadress, string lösenord);
        PersonalDTO HämtaPersonalKonto(string användarnamn, string lösenord);
        void UpdateAktivitet(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet);
        IEnumerable<InformationsutskickDTO> HämtaAllaInformationsutskick();
        List<AktivitetDTO> HämtaAktiviteterGenomInformationsutskickID(IQueryable<int> utskicksID);
        IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDTO aktuellAlumn);
        IQueryable<int> HämtaInformationsutskickIDGenomAlumn(AlumnDTO aktuellAlumn);
        AlumnDTO HämtaAlumnMedID(int användarID);
        AktivitetDTO HämtaAktivitetGenomID(int aktivitetID);
        void LäggTillAlumn(AlumnDTO alumn);
        IQueryable<int> HämtaInformationsutskickFörAlumn(AlumnDTO inloggadAlumn);
        IEnumerable<AlumnDTO> HämtaAllaAlumner();
        void LäggTillPersonal(PersonalDTO personal);
        List<KompetensDTO> HämtaKompetenserFörAlumn(AlumnDTO aktuellAlumn);
        IEnumerable<ProgramClass> HämtaAllaProgram();
        List<ProgramClass> HämtaProgramFörAlumn(AlumnDTO aktuellAlumn);
        IQueryable<AlumnAktivitetBokningDTO> HämtaBokningFörAlumn(AlumnDTO inloggadAlumn);
        void Commit();
        void LäggTillAktivitet(AktivitetDTO aktivitet);
        List<AlumnDTO> HämtaAlumnerMedProgram(ProgramDTO program);
        void LäggTillUtbildningTillAlumn(int id, string text);
        void LäggTillAlumnAktivitet(AlumnAktivitetBokningDTO alumnAktivitetBokning);
        void LäggTillKompetensTillAlumn(int id, string text);
        void TaBortProgramFrånAlumn(ProgramClass selectedProgramToRemove, AlumnDTO aktuellAlumn);
        void TaBortKompetensFrånAlumn(KompetensDTO selectedKompetensToRemove, AlumnDTO aktuellAlumn);
        void TaBortAktivitetFrånAlumn(AktivitetDTO aktivitet, AlumnDTO aktuellAlumn);
        void LäggTillInformationsutskick(InformationsutskickDTO informationsutskick);
        void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDTO informationsutskickAktivitet);
        InformationsutskickDTO HämtaInformationsutskickMedID(int utskicksID);
        void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDTO informationsutskickAlumn);
        void SkrivaAlumnAktivitetTillCSVFil(string titel, List<AlumnDTO> alumner);
        void TaBortAlumn(AlumnDTO alumnatttabort);
        List<AlumnDTO> HämtaAlumnerFrånLista(int ListID);
        void LäggTillMaillista(MaillistaDTO maillista);
        MaillistaDTO HämtaSenasteMaillista();
        void LäggTillAlumnMaillista(AlumnMaillistaDTO alumnMaillista);
        IEnumerable<MaillistaDTO> HämtaAllaMaillistor();
        List<AlumnDTO> HämtaAlumnerFrånMailLista(int maillistaID);
    }
}
