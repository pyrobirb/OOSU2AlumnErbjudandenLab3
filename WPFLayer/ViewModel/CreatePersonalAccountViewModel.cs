using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models;

namespace WPFLayer.ViewModel
{
    public class CreatePersonalAccountViewModel
    {
        private Personal personal = new Personal();

        public Personal Personal
        {
            get { return personal; }
            set { personal = value; }
        }


        public bool SkapaPersonalKonto()
        {
            if (SparaPersonal(Personal))
            {
                return true;
            }
            else return false;
        }
        public bool SparaPersonal(Personal personal)
        {
            return Personal.Spara(personal);
        }
    }
}
