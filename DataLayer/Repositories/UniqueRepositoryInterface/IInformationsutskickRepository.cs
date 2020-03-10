using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IInformationsutskickRepository : IRepository<InformationsutskickDTO>
    {
        IQueryable<int> HämtaInformationsutskickIDFörAlumn(AlumnDTO inloggadAlumn);
        void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDTO informationsutskickAktivitet);
        void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDTO informationsutskickAlumn);
        IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDTO aktuellAlumn);
        IQueryable<InformationsutskickAktivitetDTO> HämtaUtskicksIDGenomAktivitetsID(int aktivitetsID);
        IQueryable<InformationsutskickAlumnDTO> HämtaAlumnIdGenomUtskicksId(int UtskicksId);
    }
}
