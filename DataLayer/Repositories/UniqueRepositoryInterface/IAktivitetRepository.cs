using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{

    public interface IAktivitetRepository : IRepository<AktivitetDTO>
    {
        void UpdateAktivitet(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet);

        IQueryable<AlumnAktivitetBokningDTO> HämtaBokningFörAlumn(AlumnDTO inloggadAlumn);
        void TaBortAktivitetFrånAlumn(AktivitetDTO aktivitet, AlumnDTO aktuellAlumn);
        void LäggTillAlumnAktivitetBokning(AlumnAktivitetBokningDTO alumnAktivitetBokning);
        IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDTO inloggadAlumn);
        AktivitetDTO HämtaAktivitetIDGenomInformationsutskicksID(int utskicksID);
        IQueryable<AlumnAktivitetBokningDTO> HämtaAlumnGenomAktivitetsID(int aktivitetsID);
    }
}
