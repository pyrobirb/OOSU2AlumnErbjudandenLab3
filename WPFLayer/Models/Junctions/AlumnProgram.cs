using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models.Junctions.Interfaces;

namespace WPFLayer.Models.Junctions
{
    [DataContract]
    class AlumnProgram : INotifyPropertyChanged, IAlumnProgram
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        public int AlumnID { get; set; }
        [DataMember]
        public virtual Alumn Alumn { get; set; }
        [DataMember]
        public int ProgramID { get; set; }
        [DataMember]
        public virtual Program Program { get; set; }

    }
}
