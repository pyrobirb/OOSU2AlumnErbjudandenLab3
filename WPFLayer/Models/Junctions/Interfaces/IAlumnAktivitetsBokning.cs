using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Junctions.Interfaces
{
    public interface IAlumnAktivitetsBokning
    {

        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");


        int AlumnID { get; set; }
        Alumn Alumn { get; set; }
        int AktivitetID { get; set; }
        Aktivitet Aktivitet { get; set; }
    }
}
