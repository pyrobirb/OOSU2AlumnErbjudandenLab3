using AutoMapper;
using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFLayer.Models;
using WPFLayer.Models.Junctions;
using WPFLayer.View;

namespace WPFLayer.ViewModel
{
    public class LoginViewModel
    {
        BusinessManager bm = new BusinessManager();


        // Skapa ICommands...
        private readonly DelegateCommand _LoggaInCommand;
        public ICommand LoggaInCommand => _LoggaInCommand;

        private readonly DelegateCommand _SkapaAlumnKontoCommand;
        public ICommand SkapaAlumnKontoCommand => _SkapaAlumnKontoCommand;
        // ...Properties

        public LoginViewModel()
        {
            //Instantiera propertieserna...
            _LoggaInCommand = new DelegateCommand(LoggaIn);
            _SkapaAlumnKontoCommand = new DelegateCommand(SkapaAlumnKonto);
            //...Med metoderna nedan

            //Automapper Initialization
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AlumnDTO, Alumn>().ReverseMap();
                cfg.CreateMap<Alumn, AlumnDTO>().ReverseMap();
                cfg.CreateMap<Personal, PersonalDTO>().ReverseMap();
                cfg.CreateMap<AktivitetDTO, Aktivitet>().ReverseMap();
                cfg.CreateMap<InformationsutskickDTO, Informationsutskick>().ReverseMap();
                cfg.CreateMap<KompetensDTO, Kompetens>().ReverseMap();
                cfg.CreateMap<MaillistaDTO, Maillista>().ReverseMap();
                cfg.CreateMap<ProgramDTO, Program>().ReverseMap();
                cfg.CreateMap<AlumnAktivitetBokningDTO, AlumnAktivitetsBokning>().ReverseMap();
                cfg.CreateMap<AlumnKompetensDTO, AlumnKompetens>().ReverseMap();
                cfg.CreateMap<AlumnMaillistaDTO, AlumnMaillista>().ReverseMap();
                cfg.CreateMap<AlumnProgramDTO, AlumnProgram>().ReverseMap();
                cfg.CreateMap<InformationsutskickAktivitetDTO, InformationsutskickAktivitet>().ReverseMap();
                cfg.CreateMap<InformationsutskickAlumnDTO, InformationsutskickAlumn>().ReverseMap();
                cfg.CreateMap<PersonalInformationsutskickDTO, PersonalInformationsutskick>().ReverseMap();


            });
            var mapper = config.CreateMapper();
            MapperConfig.SetMapper(mapper);

        }
        private string användare;

        public string Användare
        {
            get { return användare; }
            set { användare = value; }
        }

        //Användarnamnet som ...
        private string användarnamn;

        public string Användarnamn
        {
            get { return användarnamn; }
            set { användarnamn = value; }
        }
        //...Skrivs in i textboxen





        public void LoggaIn(object commandParameter)
        {

            PasswordBox foundPwdBox =
            HelperClass.FindChild<PasswordBox>(Application.Current.MainWindow, "Lösenord");


        
            if ((Användare == null) || (Användare == ""))
            {
                MessageBox.Show("Vänligen en typ av användare att logga in som");
            }
            if (Användare == "Personal")
            {
                if (!(KontrolleraInloggningPersonal(Användarnamn, foundPwdBox.Password)))
                {
                    MessageBox.Show("Fel användarnamn eller lösenord");
                }
                else
                {
                    MainPersonalWindow mainPersonalWindow = new MainPersonalWindow();

                    foreach (var window in Application.Current.Windows)
                    {
                        if (window is MainWindow x)
                        {
                            x.Hide();
                        }
                    }


                    mainPersonalWindow.Show();
                }
            }
            if (Användare == "Alumn")
            {
                if (!(KontrolleraInloggningAlumn(Användarnamn, foundPwdBox.Password)))
                {
                    MessageBox.Show("Fel användarnamn eller lösenord");
                }
                else
                {
                    MainAlumnWindow mainAlumnWindow = new MainAlumnWindow();
                    foreach (var window in Application.Current.Windows)
                    {
                        if (window is MainWindow x)
                        {
                            x.Hide();
                        }
                    }
                    mainAlumnWindow.Show();
                }
            }


        }



        public void SkapaAlumnKonto(object commandParameter)
        {


            // skapa alumn-konto öppna ny
            // fixa en this.close(); liknande grej

            CreateAlumnAccountWindow createAlumnAccountWindow = new CreateAlumnAccountWindow();
            createAlumnAccountWindow.ShowDialog();

        }









        internal bool KontrolleraInloggningAlumn(string användarnamn, string lösenord)
        {

            if (bm.HämtaAlumnKonto(användarnamn, lösenord) != null)
            {
                GLOBALSWPF.AktuellAlumn = Alumn.HämtaAlumnKonto(användarnamn, lösenord);
                return true;
            }
            else return false;
        }



        internal bool KontrolleraInloggningPersonal(string användarnamn, string lösenord)
        {
            if (bm.HämtaPersonalKonto(användarnamn, lösenord) != null)
            {
                GLOBALSWPF.AktuellPersonal = Personal.HämtaPersonalKonto(användarnamn, lösenord);
                return true;
            }
            else return false;
        }
    }
}
