﻿using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    public class Program : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int programID;
        [DataMember]
        private string namn;
        [DataMember]
        public virtual ICollection<AlumnProgramDTO> AlumnProgram { get; set; }

        public int ProgramID
        {
            get { return programID; }
            set { programID = value; }
        }

        public string Namn
        {
            get { return namn; }
            set
            {
                namn = value;
                Changed();
            }
        }

        internal static ObservableCollection<Program> HämtaAlumnensProgram()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Program> temp = new ObservableCollection<Program>();

            foreach (var item in bm.HämtaProgramFörAlumn(GLOBALSWPF.AktuellAlumn))
            {
                temp.Add(mapper.Map<ProgramDTO, Program>(item));
            }

            return temp;
        }
    }
}
