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
    }
}
