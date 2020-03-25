using AutoMapper;
using BusinessEntites.Models;
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
using System.Windows;
using WPFLayer.ViewModel;

namespace WPFLayer.Models
{
    [DataContract]
    public class Alumn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int användarID;

        internal bool Spara(Alumn alumn)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            if ((alumn.Förnamn == null || alumn.Förnamn == "" || alumn.Efternamn == null || alumn.Efternamn == "" || alumn.Användarnamn == null || alumn.Användarnamn == "" || alumn.Lösenord == null || alumn.Lösenord == "") || !(RegexUtilities.IsValidEmail(alumn.Användarnamn)))
            {
                return false;
            }
            else
            {
                Alumn NyAlumn = new Alumn()
                {
                    Förnamn = alumn.Förnamn,
                    Efternamn = alumn.Efternamn,
                    Användarnamn = alumn.Användarnamn,
                    Lösenord = alumn.Lösenord
                };

                bm.LäggTillAlumn(mapper.Map<Alumn, AlumnDTO>(NyAlumn));

                if (bm.HämtaAlumnKonto(alumn.Användarnamn, alumn.Lösenord).Användarnamn == NyAlumn.Användarnamn)
                {
                    return true;
                }
                else return false;
            }
        }

        [DataMember]
        private string användarnamn;
        [DataMember]
        private string lösenord;
        [DataMember]
        private string förnamn;
        [DataMember]
        private string efternamn;

        [DataMember]
        public virtual ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        [DataMember]

        public virtual ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }
        [DataMember]

        public virtual ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        [DataMember]

        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        [DataMember]

        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        public int AnvändarID
        {
            get { return användarID; }
            set { användarID = value; }
        }

        public string Användarnamn
        {
            get { return användarnamn; }
            set
            {
                användarnamn = value;
                Changed();
            }
        }

        public string Lösenord
        {
            get { return lösenord; }
            set
            {
                lösenord = value;
                Changed();
            }
        }

        public string Förnamn
        {
            get { return förnamn; }
            set
            {
                förnamn = value;
                Changed();
            }
        }

        public string Efternamn
        {
            get { return efternamn; }
            set
            {
                efternamn = value;
                Changed();
            }
        }

        internal static Alumn HämtaInloggadAlumn()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            return mapper.Map<AlumnDTO, Alumn>(bm.HämtaAlumnMedID(GLOBALSWPF.AktuellAlumn.AnvändarID));
        }


        public static ObservableCollection<Alumn> HämtaAlumner()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            ObservableCollection<Alumn> Hämtadealumner = new ObservableCollection<Alumn>();

            foreach (var item in bm.HämtaAllaAlumner())
            {
                Hämtadealumner.Add(mapper.Map<AlumnDTO, Alumn>(item));
            }

            return Hämtadealumner;
        }

        internal static void TaBort()
        {

            BusinessManager bm = new BusinessManager();

            var alumnatttabort = bm.HämtaAlumnMedID((GLOBALSWPF.AktuellAlumn).AnvändarID);

            bm.TaBortAlumn(alumnatttabort);
            MessageBox.Show("Ditt konto är nu borttaget");
            bm.Commit();
        }

        internal static void SparaÄndradeUppgifter(string ändraFörnamn, string ändraEfternamn, string ändraEpostadress, string ändraLösenord)
        {
            BusinessManager bm = new BusinessManager();

            if (RegexUtilities.IsValidEmail(ändraEpostadress) == true)
            {
                var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALSWPF.AktuellAlumn.AnvändarID);
                var gammaltFörnamn = InloggadAlumn.Förnamn;
                var gammaltEfternamn = InloggadAlumn.Efternamn;
                var gammalepostadress = InloggadAlumn.Användarnamn;
                bm.UppdateraAlumn(InloggadAlumn.AnvändarID, ändraFörnamn, ändraEfternamn, ändraEpostadress, ändraLösenord);
                GLOBALSWPF.AktuellAlumn = bm.HämtaAlumnMedID(InloggadAlumn.AnvändarID);
                MessageBox.Show($"Dina uppgifter är nu uppdaterade: " +
                    $"\n{gammaltFörnamn} -> {GLOBALSWPF.AktuellAlumn.Förnamn} " +
                    $"\n{gammaltEfternamn} -> {GLOBALSWPF.AktuellAlumn.Efternamn} " +
                    $"\n{gammalepostadress} -> {GLOBALSWPF.AktuellAlumn.Användarnamn}");

            }
            else
            {
                MessageBox.Show("Var vänlig fyll i en giltig mailadress");
            }
        }
    }
}
