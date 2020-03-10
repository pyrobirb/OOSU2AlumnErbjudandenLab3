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
    public class KompetensRepository : Repository<KompetensDTO>, IKompetensRepository
    {

        public KompetensRepository(DatabaseContext context) : base(context)
        {

        }

        public IQueryable<KompetensDTO> HämtaKompetenserFörAlumn(AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnKompetens.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Include(x => x.Kompetens);

            return query.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Kompetens);
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            using (var db = new DatabaseContext())
            {
                KompetensDTO kompetens = new KompetensDTO()
                {
                    Beskrivning = text
                };
                db.Kompetenser.Add(kompetens);
                db.SaveChanges();
                db.Kompetenser.Attach(kompetens);

                AlumnKompetensDTO ak = new AlumnKompetensDTO()
                {
                    AlumnID = id,
                    KompetensID = kompetens.KompetensID
                };
                this.Context.AlumnKompetens.Add(ak);
                this.Context.SaveChanges();

            }
        }

        public void TaBortKompetensFrånAlumn(KompetensDTO selectedKompetensToRemove, AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnKompetens.Where(x => x.AlumnID == aktuellAlumn.AnvändarID && x.KompetensID == selectedKompetensToRemove.KompetensID).Select(x => x).FirstOrDefault();
            db.AlumnKompetens.Remove(query);
            db.SaveChanges();
        }
    }
}
