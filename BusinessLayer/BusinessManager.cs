using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.UnitOfWork;

namespace BusinessLayer
{
    public class BusinessManager
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public Alumn HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.AlumnRepository.HämtaAlumnKonto(användarnamn, lösenord);
        }

        public Personal HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            return unitOfWork.PersonalRepository.HämtaPersonalKonto(användarnamn, lösenord);
        }

    }
}
