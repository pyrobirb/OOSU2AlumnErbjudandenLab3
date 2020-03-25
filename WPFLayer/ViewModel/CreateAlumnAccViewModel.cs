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
        }

        internal bool SparaAlumn(Alumn Alumn)
        {
            return Alumn.Spara(Alumn);
        }


    }
}
