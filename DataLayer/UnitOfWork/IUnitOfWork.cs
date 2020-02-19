using DataLayer.Repositories.UniqueRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAlumnRepository AlumnRepository { get; set; }

        void Commit();
    }
}
