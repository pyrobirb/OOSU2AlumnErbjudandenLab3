using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{

    public interface IAktivitetRepository : IRepository<Aktivitet>
    {
        void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet);

        IQueryable<AlumnAktivitetBokning> HämtaBokningFörAlumn(Alumn inloggadAlumn);
        void TaBortAktivitetFrånAlumn(Aktivitet aktivitet, Alumn aktuellAlumn);
        void LäggTillAlumnAktivitetBokning(AlumnAktivitetBokning alumnAktivitetBokning);
        IQueryable<int> HämtaAktiviteterGenomAlumn(Alumn inloggadAlumn);
        Aktivitet HämtaAktivitetIDGenomInformationsutskicksID(int utskicksID);
        IQueryable<AlumnAktivitetBokning> HämtaAlumnGenomAktivitetsID(int aktivitetsID);
    }
}
