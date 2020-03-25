using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IProgramRepository : IRepository<ProgramDTO>
    {
        void LäggTillUtbildningTillAlumn(int id, string text);
        IQueryable<ProgramDTO> HämtaProgramFörAlumn(AlumnDTO aktuellAlumn);
        void TaBortProgramFrånAlumn(ProgramDTO selectedProgramToRemove, AlumnDTO aktuellAlumn);
        void TaBortProgram(ProgramDTO programDTO);
    }
}
