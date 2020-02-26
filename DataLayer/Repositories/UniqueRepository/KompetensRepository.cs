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
    public class KompetensRepository : Repository<Kompetens>, IKompetensRepository
    {

        public KompetensRepository(DatabaseContext context) : base(context)
        {

        }

        public IQueryable<Kompetens> HämtaKompetenserFörAlumn(Alumn aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnKompetens.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Include(x => x.Kompetens);

            return query.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Kompetens);
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            using (var db = new DatabaseContext())
            {
                Kompetens kompetens = new Kompetens()
                {
                    Beskrivning = text
                };
                db.Kompetenser.Add(kompetens);
                db.SaveChanges();
                db.Kompetenser.Attach(kompetens);

                AlumnKompetens ak = new AlumnKompetens()
                {
                    AlumnID = id,
                    KompetensID = kompetens.KompetensID
                };
                this.Context.AlumnKompetens.Add(ak);
                this.Context.SaveChanges();

            }
        }

        public void TaBortKompetensFrånAlumn(Kompetens selectedKompetensToRemove, Alumn aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnKompetens.Where(x => x.AlumnID == aktuellAlumn.AnvändarID && x.KompetensID == selectedKompetensToRemove.KompetensID).Select(x => x).FirstOrDefault();
            db.AlumnKompetens.Remove(query);
            db.SaveChanges();
        }
    }
}
