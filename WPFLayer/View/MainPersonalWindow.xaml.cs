using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFLayer.Models;
using WPFLayer.ViewModel;

namespace WPFLayer.View
{
    public class CombinedPersonalViewModel//används ej nu
    {
        public MainPersonalViewModel mainPersonalViewModel = new MainPersonalViewModel();
        public CreateActivityViewModel createActivityViewModel = new CreateActivityViewModel();
    }
    /// <summary>
    /// Interaction logic for MainPersonalWindow.xaml
    /// </summary>
    public partial class MainPersonalWindow : Window
    {
        CreateActivityViewModel c = new CreateActivityViewModel();
        public MainPersonalWindow()
        {
            InitializeComponent();
            //DataContext = new CombinedPersonalViewModel();
            DataContext = c;

            if (!(GLOBALSWPF.AktuellPersonal.Användarnamn == "SuperAdmin" && GLOBALSWPF.AktuellPersonal.PersonalID == 1))
            {
                SuperAdminPanel.Visibility = Visibility.Hidden;
            }

        }

        private void LoggaUtBtn_Click(object sender, RoutedEventArgs e)
        {
            GLOBALSWPF.AktuellPersonal = null;
            this.Close();
            Application.Current.MainWindow.Show();
        }

        public void SkapaAktivitet(object sender, RoutedEventArgs e)
        {
            //var a = new CombinedPersonalViewModel();
            //a.

            if (c.SkapaAktivitet())
            {
                MessageBox.Show("Aktiviteten har skapats!");
            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda.");
            }
        }

        public void RedigeraAktivitet(object sender, RoutedEventArgs e)
        {
            int selectedAktivitetID = ((Aktivitet)aktivitetComboBox.SelectedItem).AktivitetsID;
            string titel = RedigeraTiteltxtBox.Text;
            string kontaktperson = RedigeraKontaktpersontxtBox.Text;
            string ansvarig = RedigeraAnsvarigtxtBox.Text;
            string plats = RedigeraPlatstxtBox.Text;
            DateTime startdatum = (DateTime)RedigeraStartdatumDatePicker.SelectedDate;
            DateTime slutdatum = (DateTime)RedigeraSlutdatumDatePicker.SelectedDate;
            string beskrivning = RedigareBeskrivningTxtBox.Text;

            c.RedigeraAktiviteten(selectedAktivitetID, titel, kontaktperson, ansvarig, plats, startdatum, slutdatum, beskrivning);
        }
    }
}
