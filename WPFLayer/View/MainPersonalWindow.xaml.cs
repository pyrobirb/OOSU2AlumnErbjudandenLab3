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


        private void ProgramComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            c.FiltreraProgramAlumner((Program)ProgramComboBox.SelectedItem);
        }

        private void SkapaPersonalKonto_Click(object sender, RoutedEventArgs e)
        {
            CreatePersonalAccountWindow createPersonalAccountWindow = new CreatePersonalAccountWindow();
            this.Hide();
            createPersonalAccountWindow.Show();
        }

        private void HämtaGamlaMaillistAlumner_Click(object sender, RoutedEventArgs e)
        {
            c.ImporteraAlumnerFrånGammalMaillista((Maillista)GamlaMaillistorComboBox.SelectedItem);
        }
    }
}
