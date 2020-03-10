using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IKompetensRepository : IRepository<KompetensDto>
    {
        IQueryable<KompetensDto> HämtaKompetenserFörAlumn(AlumnDto aktuellAlumn);
        void LäggTillUtbildningTillAlumn(int id, string text);
        void TaBortKompetensFrånAlumn(KompetensDto selectedKompetensToRemove, AlumnDto aktuellAlumn);
    }
}
