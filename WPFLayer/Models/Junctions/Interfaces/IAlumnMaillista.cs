using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Junctions.Interfaces
{
    public interface IAlumnMaillista
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }
        int MaillistaID { get; set; }
        Maillista Maillista { get; set; }
    }
}
