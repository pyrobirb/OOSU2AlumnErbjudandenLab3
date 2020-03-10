﻿using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IPersonalRepository : IRepository<PersonalDto>
    {
        PersonalDto HämtaPersonalKonto(string användarnamn, string lösenord);
    }
}
