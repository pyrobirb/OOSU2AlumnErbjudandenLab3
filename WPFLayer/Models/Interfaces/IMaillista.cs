using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Interfaces
{
    public interface IMaillista
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");
        
        ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        int MaillistaID { get; set; }
        string MaillistaNamn { get; set; }

    }
}
