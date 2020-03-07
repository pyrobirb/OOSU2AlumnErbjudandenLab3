using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IAlumnRepository : IRepository<Alumn>
    {
        Alumn HämtaAlumnKonto(string användarnamn, string lösenord);
        void UppdateraAlumnKonto(int id, string förnamn, string efternamn, string epostadress);
        IQueryable<AlumnProgram> HämtaAlumnerMedProgram(Program program);
        Alumn HämtaAlumnGenomID(int AlumnID);
        void LäggTillAlumnMaillista(AlumnMaillista alumnMaillista);
    }
}
