﻿using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IMaillistRepository : IRepository<MaillistaDTO>
    {
        MaillistaDTO GetLastList();
        IQueryable<AlumnMaillistaDTO> HämtaAlumnIdGenomMaillistaID(int maillistaID);
    }
}
