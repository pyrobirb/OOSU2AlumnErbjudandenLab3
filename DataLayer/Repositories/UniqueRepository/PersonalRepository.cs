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
    public class PersonalRepository : Repository<PersonalDTO>, IPersonalRepository
    {
        public PersonalDTO HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            using (var db = new DatabaseContext())
            {
                return db.Personal.Where(x => x.Användarnamn.ToLower() == användarnamn.ToLower() && x.Lösenord == lösenord).FirstOrDefault();
            }
        }

        public PersonalRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
