using BusinessEntites.Models;
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
    }
}
