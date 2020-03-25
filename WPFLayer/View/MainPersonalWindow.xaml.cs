﻿using BusinessLayer;
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
    
    /// <summary>
    /// Interaction logic for MainPersonalWindow.xaml
    /// </summary>
    public partial class MainPersonalWindow : Window
    {
        MainPersonalViewModel c = new MainPersonalViewModel();
        public MainPersonalWindow()
        {
            InitializeComponent();
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
            MessageBox.Show("Ändringarna har sparats!");
        }

        private void ProgramComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("elo");
            c.FiltreraProgramAlumner((Program)ProgramComboBox.SelectedItem);
        }

        private void ProgramComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("elo");
            c.FiltreraProgramAlumner((Program)SkapaMaillistaFiltreraPåProgramComboBox.SelectedItem);
        }

        private void VäljAlumnTillMaillista_Click(object sender, RoutedEventArgs e)
        {
            List<Alumn> temp = new List<Alumn>();
            foreach (Alumn item in AlumnerAttFlyttaTillSkapaMaillista.SelectedItems)
            {
                temp.Add(item);
            }
            c.LäggTillAlumnerILista(temp);
        }

        public void VäljAlumnTillInformationsutskick_Click(object sender, RoutedEventArgs e)
        {
            List<Alumn> temp = new List<Alumn>();
            foreach (Alumn item in FlyttaRedigeraAlumner.SelectedItems)
            {
                temp.Add(item);
            }
            c.LäggTillAlumnerIRedigeraLista(temp);
        }

        private void SkapaPersonalKonto_Click(object sender, RoutedEventArgs e)
        {
            CreatePersonalAccountWindow createPersonalAccountWindow = new CreatePersonalAccountWindow();
            this.Hide();
            createPersonalAccountWindow.Show();
        }
    }
}
