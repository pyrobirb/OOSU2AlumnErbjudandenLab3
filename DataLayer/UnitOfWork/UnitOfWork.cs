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
        public IAktivitetRepository AktivitetRepository { get; set; }
        public IInformationsutskickRepository InformationsutskickRepository { get; set; }
        public IKompetensRepository KompetensRepository { get; set; }
        public IProgramRepository ProgramRepository { get; set; }

        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _context = databaseContext;
            AlumnRepository = new AlumnRepository(_context);
            PersonalRepository = new PersonalRepository(_context);
            AktivitetRepository = new AktivitetRepository(_context);
            InformationsutskickRepository = new InformationsutskickRepository(_context);
            KompetensRepository = new KompetensRepository(_context);
            ProgramRepository = new ProgramRepository(_context);
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        
    }
}
