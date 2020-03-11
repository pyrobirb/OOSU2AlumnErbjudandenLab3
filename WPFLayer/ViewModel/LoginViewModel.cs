using AutoMapper;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.ViewModel
{
    public class LoginViewModel
    {
        BusinessManager bm = new BusinessManager();
        internal bool KontrolleraInloggningAlumn(string användarnamn, string lösenord)
        {

            if (bm.HämtaAlumnKonto(användarnamn, lösenord) != null)
            {
                GLOBALSWPF.AktuellAlumn = bm.HämtaAlumnKonto(användarnamn, lösenord);
                return true;
            }
            else return false;
        }

        internal bool KontrolleraInloggningPersonal(string användarnamn, string lösenord)
        {
            if (bm.HämtaPersonalKonto(användarnamn, lösenord) != null)
            {
                GLOBALSWPF.AktuellPersonal = bm.HämtaPersonalKonto(användarnamn, lösenord);
                return true;
            }
            else return false;
        }
    }
}
