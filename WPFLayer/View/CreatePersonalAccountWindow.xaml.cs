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
    /// Interaction logic for CreatePersonalAccountWindow.xaml
    /// </summary>
    public partial class CreatePersonalAccountWindow : Window
    {

        CreatePersonalAccountViewModel createPersonalAccountViewModel = new CreatePersonalAccountViewModel();
        public CreatePersonalAccountWindow()
        {
            InitializeComponent();
            DataContext = createPersonalAccountViewModel;
        }



        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }

        private void SkapaPersonalKonto(object sender, RoutedEventArgs e)
        {
            if (createPersonalAccountViewModel.SkapaPersonalKonto())
            {
                MessageBox.Show("Personal-kontot är nu skapat!");
                this.Close();
                Application.Current.MainWindow.Show();
            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda.");
            }
        }
    }
}
