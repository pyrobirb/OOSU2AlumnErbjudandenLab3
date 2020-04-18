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
    public class CreatePersonalAccountViewModel
    {

        private readonly DelegateCommand _SkapaPersonalKontoCommand;
        public ICommand SkapaPersonalKontoCommand => _SkapaPersonalKontoCommand;

        private readonly DelegateCommand _TillbakaCommand;
        public ICommand TillbakaCommand => _TillbakaCommand;

        public CreatePersonalAccountViewModel()
        {
            _SkapaPersonalKontoCommand = new DelegateCommand(SkapaPersonalKonto);
            _TillbakaCommand = new DelegateCommand(Tillbaka);

        }

        private Personal personal = new Personal();

        public Personal Personal
        {
            get { return personal; }
            set { personal = value; }
        }


        private void SkapaPersonalKonto(object commandParameter)
        {
            if (SkapaPersonalKonto())
            {
                MessageBox.Show("Personal-kontot är nu skapat!");


                foreach (var window in Application.Current.Windows)
                {
                    if (window is CreatePersonalAccountWindow x)
                    {
                        x.Close();
                    }
                }

                foreach (var window in Application.Current.Windows)
                {
                    if (window is MainPersonalWindow x)
                    {
                        x.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda.");
            }
        }

        public bool SkapaPersonalKonto()
        {
            if (SparaPersonal(Personal))
            {
                return true;
            }
            else return false;
        }

        public bool SparaPersonal(Personal personal)
        {
            return Personal.Spara(personal);
        }

        private void Tillbaka(object commandParameter)
        {
            foreach (var window in Application.Current.Windows)
            {
                if (window is CreatePersonalAccountWindow x)
                {
                    x.Close();
                }
            }

            foreach (var window in Application.Current.Windows)
            {
                if (window is MainPersonalWindow x)
                {
                    x.Show();
                }
            }

            

        }
    }
}
