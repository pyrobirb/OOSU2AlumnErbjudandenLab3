using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IProgramRepository : IRepository<ProgramDto>
    {
        void LäggTillUtbildningTillAlumn(int id, string text);
        IQueryable<ProgramDto> HämtaProgramFörAlumn(AlumnDto aktuellAlumn);
        void TaBortProgramFrånAlumn(ProgramDto selectedProgramToRemove, AlumnDto aktuellAlumn);
    }
}
