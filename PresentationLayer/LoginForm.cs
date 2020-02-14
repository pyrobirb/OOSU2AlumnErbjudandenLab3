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

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        InfoutskickContext infoutskickContext = new InfoutskickContext();
        

        public LoginForm()
        {
            InitializeComponent();
            infoutskickContext.Database.EnsureDeleted();
            infoutskickContext.Database.EnsureCreated();

            AlumnProgramSeed.Populate(infoutskickContext);
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vårt syfte med alumnappen är att erbjuda alumner från högskolan i Borås aktiviteter som till exempel gästföreläsningar eller aktiviteter för att träffa personer som gått samma utbildning samt ge oss en möjlighet att kontakta alumner ifall vi behöver till exempel gästföreläsare från arbetslivet. \nVid registreringen av kontot behöver du uppge epostadress och namn som kontaktuppgifter. Sedan kan du frivilligt registrera fler uppgifter om examina, certifikat etc. \nVill du ändra på personuppgifter eller ta bord ditt konto finns den möjligheten i appen. \n\nGodkänner du villkoren?", "Villkor enligt GDPR för AlumnAppen", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                CreateUserForm createUserForm = new CreateUserForm();
                createUserForm.ShowDialog();
            }
            else
            {
                Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
