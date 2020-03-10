using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IKompetensRepository : IRepository<KompetensDTO>
    {
        IQueryable<KompetensDTO> HämtaKompetenserFörAlumn(AlumnDTO aktuellAlumn);
        void LäggTillUtbildningTillAlumn(int id, string text);
        void TaBortKompetensFrånAlumn(KompetensDTO selectedKompetensToRemove, AlumnDTO aktuellAlumn);
    }
}
