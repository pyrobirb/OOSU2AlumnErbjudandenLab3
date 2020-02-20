using BusinessEntites.Models;
using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepository
{
    public class InformationsutskickRepository : Repository<Informationsutskick>, IInformationsutskickRepository
    {
        public InformationsutskickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
