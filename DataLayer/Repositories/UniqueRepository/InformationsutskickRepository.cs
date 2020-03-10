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
    public class InformationsutskickRepository : Repository<InformationsutskickDTO>, IInformationsutskickRepository
    {
        public IQueryable<int> HämtaInformationsutskickIDFörAlumn(AlumnDTO inloggadAlumn)
        {
            var db = new DatabaseContext();

            return db.InformationsutskickAlumn.Where(x => x.AlumnID == inloggadAlumn.AnvändarID).Include(x => x.Informationsutskick).Select(x=> x.InformationsutskickID);
        }

        public void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDTO informationsutskickAktivitet)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAktivitet.Add(informationsutskickAktivitet);
            db.SaveChanges();
        }

        public void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDTO informationsutskickAlumn)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAlumn.Add(informationsutskickAlumn);
            db.SaveChanges();
        }

        public IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Informationsutskick.UtskicksID);
        }

        public IQueryable<InformationsutskickAktivitetDTO> HämtaUtskicksIDGenomAktivitetsID(int aktivitetsID)
        {
            var db = new DatabaseContext();
            //return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == AktivitetsID);
            return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == aktivitetsID);
        }

        public IQueryable<InformationsutskickAlumnDTO> HämtaAlumnIdGenomUtskicksId(int UtskicksId)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.InformationsutskickID == UtskicksId);

        }

        public InformationsutskickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
