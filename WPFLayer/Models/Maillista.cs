using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    public class Maillista : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int maillistaID;
        [DataMember]
        private string maillistaNamn;
        [DataMember]
        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        public int MaillistaID
        {
            get { return maillistaID; }
            set { maillistaID = value; }
        }

        public string MaillistaNamn
        {
            get { return maillistaNamn; }
            set
            {
                maillistaNamn = value;
                Changed();
            }
        }

    }
}
