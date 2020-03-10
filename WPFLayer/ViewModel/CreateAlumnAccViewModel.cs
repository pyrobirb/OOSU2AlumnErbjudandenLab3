﻿using BusinessEntites.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models;

namespace WPFLayer.ViewModel
{
    public class CreateAlumnAccViewModel
    {

        private Alumn alumn = new Alumn();

        public Alumn Alumn
        {
            get { return alumn; }
            set { alumn = value; } // köra Changed()
        }


        public bool SkapaAlumnKonto()
        {


            if (SparaAlumn(Alumn))
            {
                return true;
            }
            else return false;
            //Update();
        }

        internal bool SparaAlumn(Alumn Alumn)
        {

            var mapper = MapperConfig.GetMapper();

            Alumn alumn = new Alumn()
            {
                Förnamn = Alumn.Förnamn,
                Efternamn = Alumn.Efternamn,
                Användarnamn = Alumn.Användarnamn,
                Lösenord = Alumn.Lösenord
            };
            BusinessManager bm = new BusinessManager();
                
            bm.LäggTillAlumn(mapper.Map<Alumn, AlumnDTO>(alumn));

            if (bm.HämtaAlumnKonto(alumn.Användarnamn, alumn.Lösenord).Användarnamn == alumn.Användarnamn)
            {
                return true;
            }
            else return false;

        }


    }
}
