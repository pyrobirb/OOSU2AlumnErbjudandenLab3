using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepository;
using DataLayer.Repositories.UniqueRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAlumnRepository AlumnRepository { get; set; }
        public IPersonalRepository PersonalRepository { get; set; }

        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _context = databaseContext;
            AlumnRepository = new AlumnRepository(_context);
            PersonalRepository = new PersonalRepository(_context);
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
