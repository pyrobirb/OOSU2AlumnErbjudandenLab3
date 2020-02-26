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
        public IQueryable<InformationsutskickAlumn> HämtaInformationsutskickFörAlumn(Alumn inloggadAlumn)
        {
            var db = new DatabaseContext();

            return db.InformationsutskickAlumn.Where(x => x.Alumn == inloggadAlumn).Include(x => x.Informationsutskick).AsQueryable();



        }

        public InformationsutskickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
