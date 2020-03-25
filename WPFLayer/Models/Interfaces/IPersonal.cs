using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Interfaces
{
    public interface IPersonal
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");
        bool Spara(Personal personal);
        int PersonalID { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }

    }
}
