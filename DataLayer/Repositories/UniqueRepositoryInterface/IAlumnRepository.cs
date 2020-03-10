using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IAlumnRepository : IRepository<AlumnDto>
    {
        AlumnDto HämtaAlumnKonto(string användarnamn, string lösenord);
        void UppdateraAlumnKonto(int id, string förnamn, string efternamn, string epostadress);
        IQueryable<AlumnProgramDto> HämtaAlumnerMedProgram(ProgramDto program);
        AlumnDto HämtaAlumnGenomID(int AlumnID);
        void LäggTillAlumnMaillista(AlumnMaillistaDto alumnMaillista);
    }
}
