using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IInformationsutskickRepository : IRepository<Informationsutskick>
    {
        IQueryable<int> HämtaInformationsutskickIDFörAlumn(Alumn inloggadAlumn);
        void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitet informationsutskickAktivitet);
        void LäggTillInformationsutskickAlumn(InformationsutskickAlumn informationsutskickAlumn);
        IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(Alumn aktuellAlumn);
    }
}
