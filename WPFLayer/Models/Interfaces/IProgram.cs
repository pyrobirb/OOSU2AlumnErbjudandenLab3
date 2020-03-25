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
    public interface IProgram
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");
        
        ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        int ProgramID { get; set; }
        string Namn { get; set; }

    }
}
