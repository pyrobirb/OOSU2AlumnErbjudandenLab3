using AutoMapper;
using BusinessEntites.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFLayer.Models;
using WPFLayer.View;
using WPFLayer.ViewModel;

namespace WPFLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Automapper Initialization
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile<AlumnContextProfile>();
                cfg.CreateMap<AlumnDTO, Alumn>().ReverseMap();
                cfg.CreateMap<Personal, PersonalDTO>().ReverseMap();

            });
            var mapper = config.CreateMapper();
            MapperConfig.SetMapper(mapper);

        }

        

        private void CreateAlumnAccBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateAlumnAccountWindow createAlumnAccountWindow = new CreateAlumnAccountWindow();
            createAlumnAccountWindow.ShowDialog();
        }
    }
}
