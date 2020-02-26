using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepository
{
    public class ProgramRepository : Repository<Program>, IProgramRepository
    {
        public ProgramRepository(DatabaseContext context) : base(context)
        {

        }

        public IQueryable<Program> HämtaProgramFörAlumn(Alumn aktuellAlumn)
        {
            var db = new DatabaseContext();
            
                var query =  db.AlumnProgram.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Include(x=> x.Program);

                return query.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Program);
            
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            using (var db = new DatabaseContext())
            {
                Program program = new Program()
                {
                    Namn = text
                };
                db.Program.Add(program);
                db.SaveChanges();

                db.Program.Attach(program);

                AlumnProgram ap = new AlumnProgram()
                {
                    AlumnID = id,
                    ProgramID = program.ProgramID
                };
                this.Context.AlumnProgram.Add(ap);
                this.Context.SaveChanges();

            }
        }

        public void TaBortProgramFrånAlumn(Program selectedProgramToRemove, Alumn aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnProgram.Where(x => x.AlumnID == aktuellAlumn.AnvändarID && x.ProgramID == selectedProgramToRemove.ProgramID).Select(x => x).FirstOrDefault();
            db.AlumnProgram.Remove(query);
            db.SaveChanges();
        }
    }
}
