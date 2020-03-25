using BusinessEntites.Models;
using BusinessLayer;
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

        public bool Spara(Personal personal)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            if ((personal.Förnamn == null || personal.Förnamn == "" || personal.Efternamn == null || personal.Efternamn == "" || personal.Användarnamn == null || personal.Användarnamn == "" || personal.Lösenord == null || personal.Lösenord == ""))
            {
                return false;
            }
            else
            {
                Personal NyAlumn = new Personal()
                {
                    Förnamn = personal.Förnamn,
                    Efternamn = personal.Efternamn,
                    Användarnamn = personal.Användarnamn,
                    Lösenord = personal.Lösenord
                };

                bm.LäggTillPersonal(mapper.Map<Personal, PersonalDTO>(NyAlumn));

                if (bm.HämtaPersonalKonto(personal.Användarnamn, personal.Lösenord).Användarnamn == NyAlumn.Användarnamn)
                {
                    return true;
                }
                else return false;
            }
        }

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
            set { användarnamn = value; 
                Changed(); }
        }
        public string Lösenord
        {
            get { return lösenord; }
            set { lösenord = value; 
                Changed(); }
        }
        public string Förnamn
        {
            get { return förnamn; }
            set { förnamn = value; 
                Changed(); }
        }

        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; 
                Changed(); }
        }
    }
}
