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
    public class InformationsutskickRepository : Repository<InformationsutskickDto>, IInformationsutskickRepository
    {
        public IQueryable<int> HämtaInformationsutskickIDFörAlumn(AlumnDto inloggadAlumn)
        {
            var db = new DatabaseContext();

            return db.InformationsutskickAlumn.Where(x => x.AlumnID == inloggadAlumn.AnvändarID).Include(x => x.Informationsutskick).Select(x=> x.InformationsutskickID);
        }

        public void LäggTillInformationsutskickAktivitet(InformationsutskickAktivitetDto informationsutskickAktivitet)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAktivitet.Add(informationsutskickAktivitet);
            db.SaveChanges();
        }

        public void LäggTillInformationsutskickAlumn(InformationsutskickAlumnDto informationsutskickAlumn)
        {
            var db = new DatabaseContext();
            db.InformationsutskickAlumn.Add(informationsutskickAlumn);
            db.SaveChanges();
        }

        public IQueryable<int> HämtaInformationsutskickAlumnGenomAlumnID(AlumnDto aktuellAlumn)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Informationsutskick.UtskicksID);
        }

        public IQueryable<InformationsutskickAktivitetDto> HämtaUtskicksIDGenomAktivitetsID(int aktivitetsID)
        {
            var db = new DatabaseContext();
            //return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == AktivitetsID);
            return db.InformationsutskickAktivitet.Where(x => x.AktivitetID == aktivitetsID);
        }

        public IQueryable<InformationsutskickAlumnDto> HämtaAlumnIdGenomUtskicksId(int UtskicksId)
        {
            var db = new DatabaseContext();
            return db.InformationsutskickAlumn.Where(x => x.InformationsutskickID == UtskicksId);

        }

        public InformationsutskickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
