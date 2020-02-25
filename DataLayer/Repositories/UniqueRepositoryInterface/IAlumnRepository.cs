﻿using BusinessEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepositoryInterface
{
    public interface IAlumnRepository : IRepository<Alumn>
    {
        Alumn HämtaAlumnKonto(string användarnamn, string lösenord);

    }
}