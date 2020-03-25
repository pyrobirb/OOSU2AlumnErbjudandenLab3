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
    public interface IKompetens
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");

        ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }

        int KompetensID { get; set; }
        string Beskrivning { get; set; }
    }
}
