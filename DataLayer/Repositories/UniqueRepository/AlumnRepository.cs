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
    public class AlumnRepository : Repository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(DbContext context) : base(context)
        {

        }
    }
}
