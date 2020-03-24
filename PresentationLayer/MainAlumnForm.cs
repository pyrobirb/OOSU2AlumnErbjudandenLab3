using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using BusinessLayer;
using DataLayer.Contexts;
using ProgramClass = BusinessEntites.Models.ProgramDTO;

namespace PresentationLayer
{
    public partial class MainAlumnForm : Form
    {
        BusinessManager bm = new BusinessManager();
        DatabaseContext dbContext = new DatabaseContext();
        WarningLabel WarningLabel = new WarningLabel();
        btnDeleteAccountOP btnDeleteAccountOP = new btnDeleteAccountOP();


        public MainAlumnForm()
        {
            InitializeComponent();

            //Observer
            this.tabControlAlumn.TabPages[3].Controls.Add(WarningLabel);
            this.tabControlAlumn.TabPages[3].Controls.Add(btnDeleteAccountOP);
            //this.Controls.Add(btnDeleteAccountOP);
            WarningLabel.Location = placeHolderWarningLabel.Location;
            btnDeleteAccountOP.Location = btnDeleteAccount.Location;
            btnDeleteAccountOP.Click += btnDeleteAccount_Click;
            btnDeleteAccount.Hide();// = false;
            placeHolderWarningLabel.Hide();

            WarningLabel.Text = placeHolderWarningLabel.Text;
            WarningLabel.Width = placeHolderWarningLabel.Width;
            WarningLabel.ForeColor = Color.Crimson;

            WarningLabel.Hide();
            btnDeleteAccountOP.Text = btnDeleteAccount.Text;
            btnDeleteAccountOP.Size = btnDeleteAccount.Size;
            btnDeleteAccountOP.subject.register(WarningLabel);

        }
        public void UppdateraBokadeAktiviteter()
        {
            bokadeAktiviteterListBox.DataSource = bm.HämtaAktiviteterGenomAktivitetID(bm.HämtaAktiviteterGenomAlumn(GLOBALS.AktuellAlumn));
            bokadeAktiviteterListBox.DisplayMember = "Titel";
            bokadeAktiviteterListBox.ValueMember = "AktivitetsID";
        }
        public void UppdateraKommandeAktiviteter()
        {
            informationsutskickListBox.DataSource = bm.HämtaAktiviteterGenomInformationsutskickID(bm.HämtaInformationsutskickAlumnGenomAlumnID(GLOBALS.AktuellAlumn));
            informationsutskickListBox.DisplayMember = "Titel";
            informationsutskickListBox.ValueMember = "AktivitetsID";
        }
        private void tabControlAlumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AnvändarUppgifter
            var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALS.AktuellAlumn.AnvändarID);
            ändraFörnamnTxtBox.Text = InloggadAlumn.Förnamn;
            ändraEfternamnTxtBox.Text = InloggadAlumn.Efternamn;
            ändraEpostTxtBox.Text = InloggadAlumn.Användarnamn;

            //Alumnuppgifter
            UppdateraKommandeAktiviteter();
            UppdateraBokadeAktiviteter();
            UppdateraProgramListBox();
            UppdateraKompetenserListBox();

        }

        private void MainAlumnForm_Load(object sender, EventArgs e)
        {
            UppdateraKommandeAktiviteter();
           
            aktivitetsBeskrivningTextBox.Text = "";
            
            AktivitetDTO valdAktivitet = (AktivitetDTO)informationsutskickListBox.SelectedItem;
            if (valdAktivitet != null)
            {
                aktivitetsBeskrivningTextBox.Text = valdAktivitet.Beskrivning;
            }

            UppdateraBokadeAktiviteter();
        }

        private void btnBookActivity_Click(object sender, EventArgs e)
        {
            AktivitetDTO bokadAktivitet = (AktivitetDTO)informationsutskickListBox.SelectedItem;

            AlumnAktivitetBokningDTO alumnAktivitetBokning = new AlumnAktivitetBokningDTO()
            {
                AlumnID = GLOBALS.AktuellAlumn.AnvändarID,
                AktivitetID = bokadAktivitet.AktivitetsID,
            };
            dbContext.AlumnAktivitet.Add(alumnAktivitetBokning);
            dbContext.SaveChanges();
            MessageBox.Show("Bokningen har skapats");

        }

        private void informationsutskickListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktivitetDTO valdAktivitet = (AktivitetDTO)informationsutskickListBox.SelectedItem;
            if (valdAktivitet != null)
            {
                aktivitetsBeskrivningTextBox.Text = valdAktivitet.Beskrivning;
            }
        }

        private void bokadeAktiviteterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktivitetDTO valdBokadAktivitet = (AktivitetDTO)bokadeAktiviteterListBox.SelectedItem;
            if (valdBokadAktivitet != null)
            {
                aktivitetsinformationRichTextBox.Text = valdBokadAktivitet.Beskrivning;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (RegexUtilities.IsValidEmail(ändraEpostTxtBox.Text) == true)
            {

            var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALS.AktuellAlumn.AnvändarID);
            var gammaltFörnamn = InloggadAlumn.Förnamn;
            var gammaltEfternamn = InloggadAlumn.Efternamn;
            var gammalepostadress = InloggadAlumn.Användarnamn;
            bm.UppdateraAlumn(InloggadAlumn.AnvändarID, ändraFörnamnTxtBox.Text, ändraEfternamnTxtBox.Text, ändraEpostTxtBox.Text);
            GLOBALS.AktuellAlumn = bm.HämtaAlumnMedID(InloggadAlumn.AnvändarID);
            MessageBox.Show($"Dina uppgifter är nu uppdaterade: " +
                $"\n{gammaltFörnamn} -> {GLOBALS.AktuellAlumn.Förnamn} " +
                $"\n{gammaltEfternamn} -> {GLOBALS.AktuellAlumn.Efternamn} " +
                $"\n{gammalepostadress} -> {GLOBALS.AktuellAlumn.Användarnamn}");
            }
            else
            {
                MessageBox.Show("Var vänlig fyll i en giltig mailadress");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var alumnatttabort = bm.HämtaAlumnMedID((GLOBALS.AktuellAlumn).AnvändarID);
          
            bm.TaBortAlumn(alumnatttabort);
            MessageBox.Show("Ditt konto är nu borttaget");
            bm.Commit();
            DialogResult = DialogResult.OK;
            GLOBALS.AktuellAlumn = null;
        }


        private void läggTillUtbildningBtn_Click(object sender, EventArgs e)
        {
            bm.LäggTillUtbildningTillAlumn(GLOBALS.AktuellAlumn.AnvändarID, nyUtbildningTxtBox.Text);
            UppdateraProgramListBox();

        }

        private void UppdateraProgramListBox()
        {
            programListBox.DataSource = bm.HämtaProgramFörAlumn(GLOBALS.AktuellAlumn);
            programListBox.DisplayMember = "Namn";
            programListBox.ValueMember = "ProgramID";
        }

        private void LäggTillArbetslivserfarenhetBtn_Click(object sender, EventArgs e)
        {
            bm.LäggTillKompetensTillAlumn(GLOBALS.AktuellAlumn.AnvändarID, nyArbetslivserfarenhetTxtBox.Text);
            UppdateraKompetenserListBox();

        }

        private void UppdateraKompetenserListBox()
        {
            kompetenserListBox.DataSource = bm.HämtaKompetenserFörAlumn(GLOBALS.AktuellAlumn);
            kompetenserListBox.DisplayMember = "Beskrivning";
            kompetenserListBox.ValueMember = "KompetensID";
        }

        private void taBortValtProgramBtn_Click(object sender, EventArgs e)
        {
            var selectedProgramToRemove = (ProgramClass)programListBox.SelectedItem;
            bm.TaBortProgramFrånAlumn(selectedProgramToRemove, GLOBALS.AktuellAlumn);
            UppdateraProgramListBox();
        }

        private void taBortvaldKompetensBtn_Click(object sender, EventArgs e)
        {
            var selectedKompetensToRemove = (KompetensDTO)kompetenserListBox.SelectedItem;
            bm.TaBortKompetensFrånAlumn(selectedKompetensToRemove, GLOBALS.AktuellAlumn);
            UppdateraKompetenserListBox();
        }

        private void btnCancelBookedActivity_Click(object sender, EventArgs e)
        {
            AktivitetDTO aktivitet = (AktivitetDTO)bokadeAktiviteterListBox.SelectedItem;
            aktivitetsinformationRichTextBox.Clear();
            bm.TaBortAktivitetFrånAlumn(aktivitet, GLOBALS.AktuellAlumn);
            UppdateraBokadeAktiviteter();
            MessageBox.Show("Bokningen har raderats");

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnDeleteAccount_MouseEnter(object sender, EventArgs e)
        {

        }

        private void programListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
