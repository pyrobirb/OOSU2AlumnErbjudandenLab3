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
using WPFLayer.ViewModel;

namespace WPFLayer.View
{
    /// <summary>
    /// Interaction logic for MainAlumnWindow.xaml
    /// </summary>
    public partial class MainAlumnWindow : Window
    {
        MainAlumnViewModel mainAlumnViewModel = new MainAlumnViewModel();
        public MainAlumnWindow()
        {
            InitializeComponent();
            DataContext = mainAlumnViewModel;
            

        }

        //private void SparaÄndringarBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    mainAlumnViewModel.SparaÄndradeAnvändaruppgifter(ÄndraFörnamn.Text, ÄndraEfternamn.Text, ÄndraEpostadress.Text, ÄndraLösenord.Text);
        //}

        //private void RaderaKontoBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    mainAlumnViewModel.TaBortAlumnKonto();
        //    GLOBALSWPF.AktuellAlumn = null;
        //    this.Close();
        //    Application.Current.MainWindow.Show();
        //}

        private void LoggaUtBtn_Click(object sender, RoutedEventArgs e)
        {
            GLOBALSWPF.AktuellAlumn = null;
            this.Close();
            Application.Current.MainWindow.Show();
        }

        //private void BokaValdAktivitet_Click(object sender, RoutedEventArgs e)
        //{
        //    mainAlumnViewModel.BokaValdAktivitet(KommandeAktiviteterListBox.SelectedItem);
            
        //}

        //private void AvbokaValdAktivitetButton_Click(object sender, RoutedEventArgs e)
        //{
        //    mainAlumnViewModel.AvbokaValdAktivitet(BokadeAktiviteterListbox.SelectedItem);
        //    AktivitetInfoRichTxtBox.Clear();
        //}

        private void LäggTillUtbildningHögskolanIBoråsButton_Click(object sender, RoutedEventArgs e)
        {
            mainAlumnViewModel.LäggtillUtbildning(LäggTillUtbildningHögskolanIBoråsTextBox.Text);
            LäggTillUtbildningHögskolanIBoråsTextBox.Clear();
        }

        private void LäggTillKompetens_ArbetlivserfarenhetButton_Click(object sender, RoutedEventArgs e)
        {
            mainAlumnViewModel.LäggTillKompetens(LäggTillKompetens_ArbetlivserfarenhetTextBox.Text);
            LäggTillKompetens_ArbetlivserfarenhetTextBox.Clear();
        }

        private void TabortProgramButton_Click(object sender, RoutedEventArgs e)
        {
            mainAlumnViewModel.TaBortProgram(ProgramListBox.SelectedItem);
        }

        private void TabortKOmpetensButton_Click(object sender, RoutedEventArgs e)
        {
            mainAlumnViewModel.TaBortKompetens(KompetenserListBox.SelectedItem);
        }
    }
}
