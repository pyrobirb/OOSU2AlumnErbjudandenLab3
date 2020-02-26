using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IKompetensRepository : IRepository<Kompetens>
    {
        IQueryable<Kompetens> HämtaKompetenserFörAlumn(Alumn aktuellAlumn);
        void LäggTillUtbildningTillAlumn(int id, string text);
        void TaBortKompetensFrånAlumn(Kompetens selectedKompetensToRemove, Alumn aktuellAlumn);
    }
}
