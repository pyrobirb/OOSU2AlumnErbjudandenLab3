using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Contexts;
using DataLayer;
using DataLayer.Seed;
using BusinessEntites.Models;
using BusinessEntites;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        DatabaseContext dbContext = new DatabaseContext();
        BusinessManager bm = new BusinessManager();
        BusinessEntities businessEntities = new BusinessEntities();
        

        public LoginForm()
        {
            InitializeComponent();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            Seed.Populate(dbContext);
            FyllAktivaAktiviteter();
        }

        private void FyllAktivaAktiviteter()
        {
            AktivaAktiviteter aktivaAktiviteter = new AktivaAktiviteter();
            aktivaAktiviteter.Aktiviteter = 
            bm.ListaAllaAktuellaAktiviteter();
        }

        private void ShowForm(Form form)
        {
            Visible = !Visible;
            if (form.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vårt syfte med alumnappen är att erbjuda alumner från högskolan i Borås aktiviteter som till exempel gästföreläsningar eller aktiviteter för att träffa personer som gått samma utbildning samt ge oss en möjlighet att kontakta alumner ifall vi behöver till exempel gästföreläsare från arbetslivet. \nVid registreringen av kontot behöver du uppge epostadress och namn som kontaktuppgifter. Sedan kan du frivilligt registrera fler uppgifter om examina, certifikat etc. \nVill du ändra på personuppgifter eller ta bord ditt konto finns den möjligheten i appen. \n\nGodkänner du villkoren?", "Villkor enligt GDPR för AlumnAppen", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                ShowForm(new CreateUserForm());
            }
            else
            {
                Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string användarnamn = AnvändarnamnTextBox.Text;
            string lösenord = LösenordTxtBox.Text;

            GLOBALS.AktuellAlumn = bm.HämtaAlumnKonto(användarnamn, lösenord);
            GLOBALS.AktuellPersonal = bm.HämtaPersonalKonto(användarnamn, lösenord);

            if (GLOBALS.AktuellAlumn != null)
                ShowForm(new MainAlumnForm());

            if (GLOBALS.AktuellPersonal != null)
                ShowForm(new MainPersonalForm());

            if ((GLOBALS.AktuellAlumn == null) && (GLOBALS.AktuellPersonal == null))
                FelInlogLabel.Visible = true;

            
        }


        private void AnvändarnamnTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
