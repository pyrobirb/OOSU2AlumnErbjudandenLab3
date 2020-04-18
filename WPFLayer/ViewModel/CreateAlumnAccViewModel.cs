using BusinessEntites.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFLayer.Models;
using WPFLayer.View;

namespace WPFLayer.ViewModel
{
    public class CreateAlumnAccViewModel
    {

        private readonly DelegateCommand _SkapaAlumnKontoCommand;
        public ICommand SkapaAlumnKontoCommand => _SkapaAlumnKontoCommand; 
        
        private readonly DelegateCommand _TillbakaCommand;
        public ICommand TillbakaCommand => _TillbakaCommand;


        public CreateAlumnAccViewModel()
        {
            _SkapaAlumnKontoCommand = new DelegateCommand(SkapaAlumnKonto);
            _TillbakaCommand = new DelegateCommand(Tillbaka);
        }


        private Alumn alumn = new Alumn();

        public Alumn Alumn
        {
            get { return alumn; }
            set { alumn = value; } // köra Changed()
        }






        private void SkapaAlumnKonto(object commandParameter)
        {
            if (SkapaAlumnKonto())
            {
                MessageBox.Show("Ditt Alumn-konto är nu skapat! Var god logga in.");

                foreach (var window in Application.Current.Windows)
                {
                    if (window is CreateAlumnAccountWindow x)
                    {
                        x.Close();
                    }
                }

                Application.Current.MainWindow.Show();
            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda. Se även till att eposten är en giltig epostadress.");

            }

        }

        private void Tillbaka(object commandParameter)
        {
            foreach (var window in Application.Current.Windows)
            {
                if (window is CreateAlumnAccountWindow x)
                {
                    x.Close();
                }
            }

            var anvNamn = HelperClass.FindChild<TextBox>(Application.Current.MainWindow, "InloggAnvändarnamn");
            anvNamn.Text = "";

            var pwdBox = HelperClass.FindChild<PasswordBox>(Application.Current.MainWindow, "Lösenord");
            pwdBox.Clear();

            Application.Current.MainWindow.Show();

        }

        public bool SkapaAlumnKonto()
        {
            if (SparaAlumn(Alumn))
            {
                return true;
            }
            else return false;
        }

        internal bool SparaAlumn(Alumn Alumn)
        {
            return Alumn.Spara(Alumn);
        }


    }
}
