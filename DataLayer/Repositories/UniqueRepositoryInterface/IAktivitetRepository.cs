using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{

    public interface IAktivitetRepository : IRepository<AktivitetDto>
    {
        void UpdateAktivitet(AktivitetDto aktivitet, AktivitetDto nyaktivitet);

        IQueryable<AlumnAktivitetBokningDto> HämtaBokningFörAlumn(AlumnDto inloggadAlumn);
        void TaBortAktivitetFrånAlumn(AktivitetDto aktivitet, AlumnDto aktuellAlumn);
        void LäggTillAlumnAktivitetBokning(AlumnAktivitetBokningDto alumnAktivitetBokning);
        IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDto inloggadAlumn);
        AktivitetDto HämtaAktivitetIDGenomInformationsutskicksID(int utskicksID);
        IQueryable<AlumnAktivitetBokningDto> HämtaAlumnGenomAktivitetsID(int aktivitetsID);
    }
}
