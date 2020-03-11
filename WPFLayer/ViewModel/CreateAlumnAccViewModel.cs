using BusinessEntites.Models;
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
        BusinessManager bm = new BusinessManager();

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

            if ((Alumn.Förnamn == null || Alumn.Förnamn == "" || Alumn.Efternamn == null || Alumn.Efternamn == "" || Alumn.Användarnamn == null || Alumn.Användarnamn == "" || Alumn.Lösenord == null || Alumn.Lösenord == "") || !(RegexUtilities.IsValidEmail(Alumn.Användarnamn)))
            {
                return false;
            }
            else
            {
                Alumn alumn = new Alumn()
                {
                    Förnamn = Alumn.Förnamn,
                    Efternamn = Alumn.Efternamn,
                    Användarnamn = Alumn.Användarnamn,
                    Lösenord = Alumn.Lösenord
                };

                bm.LäggTillAlumn(mapper.Map<Alumn, AlumnDTO>(alumn));

                if (bm.HämtaAlumnKonto(alumn.Användarnamn, alumn.Lösenord).Användarnamn == alumn.Användarnamn)
                {
                    return true;
                }
                else return false;
            }

        }


    }
}
