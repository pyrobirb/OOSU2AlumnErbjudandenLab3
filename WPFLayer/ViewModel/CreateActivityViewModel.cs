using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models;

namespace WPFLayer.ViewModel
{
    public class CreateActivityViewModel
    {
        BusinessManager bm = new BusinessManager();

        private Aktivitet aktivitet = new Aktivitet();

        public Aktivitet Aktivitet
        {
            get { return aktivitet; }
            set { aktivitet = value; } // köra Changed()
        }
    }
}
