using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IProgramRepository : IRepository<Program>
    {
        void LäggTillUtbildningTillAlumn(int id, string text);
        IQueryable<Program> HämtaProgramFörAlumn(Alumn aktuellAlumn);
        void TaBortProgramFrånAlumn(Program selectedProgramToRemove, Alumn aktuellAlumn);
    }
}
