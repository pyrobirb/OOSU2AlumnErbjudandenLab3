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
    /// Interaction logic for CreateAlumnAccountWindow.xaml
    /// </summary>
    public partial class CreateAlumnAccountWindow : Window
    {
        CreateAlumnAccViewModel createAlumnAccViewModel = new CreateAlumnAccViewModel();

        public CreateAlumnAccountWindow()
        {
            InitializeComponent();
            DataContext = createAlumnAccViewModel;
        }


        private void SkapaAlumnKonto(object sender, RoutedEventArgs e)
        {
            if (createAlumnAccViewModel.SkapaAlumnKonto())
            {
                MessageBox.Show("Ditt Alumn-konto är nu skapat! Var god logga in.");
                this.Close();
                Application.Current.MainWindow.Show();
            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda. Se även till att eposten är en giltig epostadress.");

            }

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
            
        }
    }
}
