using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepository
{
    public class AlumnRepository : Repository<AlumnDto>, IAlumnRepository
    {
        public AlumnDto HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            using (var db = new DatabaseContext())
            {
                return db.Alumner.Where(x => x.Användarnamn.ToLower() == användarnamn.ToLower() && x.Lösenord == lösenord).FirstOrDefault();
            }
        }

        public void UppdateraAlumnKonto(int id, string förnamn, string efternamn, string epostadress)
        {
            var alumn = this.GetById(id);
            this.Context.Alumner.Attach(alumn);
            alumn.Förnamn = förnamn;
            alumn.Efternamn = efternamn;
            alumn.Användarnamn = epostadress;
            this.Context.SaveChanges();
        }

        public IQueryable<AlumnProgramDto> HämtaAlumnerMedProgram(ProgramDto program)
        {
            var db = new DatabaseContext();

            return db.AlumnProgram.Where(x => x.Program == program);
        }

        public AlumnDto HämtaAlumnGenomID(int AlumnID)
        {
            var db = new DatabaseContext();
            return db.Alumner.Where(x => x.AnvändarID == AlumnID).FirstOrDefault();
        }

        public void LäggTillAlumnMaillista(AlumnMaillistaDto alumnMaillista)
        {
            var db = new DatabaseContext();
            db.AlumnMaillist.Add(alumnMaillista);
            db.SaveChanges();
        }

        public AlumnRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
