using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Junctions.Interfaces
{
    public interface IAlumnKompetens
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");

        Alumn Alumn { get; set; }
        Kompetens Kompetens { get; set; }
        int KompetensID { get; set; }
        int AlumnID { get; set; }

    }
}
