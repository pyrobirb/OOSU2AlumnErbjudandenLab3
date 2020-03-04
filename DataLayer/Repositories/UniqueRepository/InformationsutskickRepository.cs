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
    public class InformationsutskickRepository : Repository<Informationsutskick>, IInformationsutskickRepository
    {
        public IQueryable<int> HämtaInformationsutskickIDFörAlumn(Alumn inloggadAlumn)
        {
            var db = new DatabaseContext();

            return db.InformationsutskickAlumn.Where(x => x.AlumnID == inloggadAlumn.AnvändarID).Include(x => x.Informationsutskick).Select(x=> x.InformationsutskickID);
        }

        public void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitet informationsutskickAktivitet)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAktivitet.Add(informationsutskickAktivitet);
            db.SaveChanges();
        }

        public void LäggTillInformationsutskickAlumn(InformationsutskickAlumn informationsutskickAlumn)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAlumn.Add(informationsutskickAlumn);
            db.SaveChanges();
        }

        public IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(Alumn aktuellAlumn)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Informationsutskick.UtskicksID);
        }

        public IQueryable<InformationsutskickAktivitet> HämtaUtskicksIDGenomAktivitetsID(int aktivitetsID)
        {
            var db = new DatabaseContext();
            //return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == AktivitetsID);
            return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == aktivitetsID);
        }

        public IQueryable<InformationsutskickAlumn> HämtaAlumnIdGenomUtskicksId(int UtskicksId)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.InformationsutskickID == UtskicksId);

        }

        public InformationsutskickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
