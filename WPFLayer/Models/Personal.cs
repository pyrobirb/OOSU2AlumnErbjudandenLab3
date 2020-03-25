using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models.Interfaces;

namespace WPFLayer.Models
{
    [DataContract]
    public class Personal : INotifyPropertyChanged, IPersonal
    {


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int personalID;
        [DataMember]
        private string användarnamn;
        [DataMember]
        private string lösenord;
        [DataMember]
        private string förnamn;
        [DataMember]
        private string efternamn;

        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        public string Användarnamn
        {
            get { return användarnamn; }
            set { användarnamn = value; }
        }
        public string Lösenord
        {
            get { return lösenord; }
            set { lösenord = value; }
        }
        public string Förnamn
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }
    }
}
