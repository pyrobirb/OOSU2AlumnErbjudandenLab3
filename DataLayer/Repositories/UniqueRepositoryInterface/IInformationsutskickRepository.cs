using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IInformationsutskickRepository : IRepository<InformationsutskickDto>
    {
        IQueryable<int> HämtaInformationsutskickIDFörAlumn(AlumnDto inloggadAlumn);
        void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDto informationsutskickAktivitet);
        void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDto informationsutskickAlumn);
        IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDto aktuellAlumn);
        IQueryable<InformationsutskickAktivitetDto> HämtaUtskicksIDGenomAktivitetsID(int aktivitetsID);
        IQueryable<InformationsutskickAlumnDto> HämtaAlumnIdGenomUtskicksId(int UtskicksId);
    }
}
