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
using ProgramClass = BusinessEntites.Models.Program;

namespace PresentationLayer
{
    public partial class MainAlumnForm : Form
    {
        DatabaseContext dbContext = new DatabaseContext();
        BusinessManager bm = new BusinessManager();
        public MainAlumnForm()
        {
            InitializeComponent();
            kollaNyaMeddelanden();
        }

        private void tabControlAlumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visa bokade aktiviteter
            bokadeAktiviteterListBox.Items.Clear();
            foreach (AlumnAktivitetBokning alumnBokning in bm.HämtaBokningFörAlumn(GLOBALS.AktuellAlumn))
            {
                int aktivitetID = alumnBokning.AktivitetID;
                Aktivitet aktivitet = bm.unitOfWork.AktivitetRepository.GetById(aktivitetID);

                if (aktivitet != null)
                {
                    bokadeAktiviteterListBox.Items.Add(aktivitet);
                    bokadeAktiviteterListBox.DisplayMember = "Titel";
                    bokadeAktiviteterListBox.ValueMember = "AktivitetsID";
                }
            }

            kollaNyaMeddelanden();

            //AnvändarUppgifter
            var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALS.AktuellAlumn.AnvändarID);
            ändraFörnamnTxtBox.Text = InloggadAlumn.Förnamn;
            ändraEfternamnTxtBox.Text = InloggadAlumn.Efternamn;
            ändraEpostTxtBox.Text = InloggadAlumn.Användarnamn;

            //Alumnuppgifter
            UppdateraProgramListBox();
            UppdateraKompetenserListBox();

            ////Kolla om det finns nytt meddelande
            //InloggadAlumn.newMessages = true;

            //if (InloggadAlumn.newMessages)
            //{
            //    MessageBox.Show("Nu finns det nya aktiteter att anmäla sig till.");
            //}

        }

        public void kollaNyaMeddelanden()
        {
            //Kolla om det finns nytt meddelande
            var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALS.AktuellAlumn.AnvändarID);

            if (InloggadAlumn.newMessages)
            {
                MessageBox.Show("Nu finns det nya aktiteter att anmäla sig till.");
                InloggadAlumn.newMessages = false;
                bm.updateNewMessage(InloggadAlumn.AnvändarID, false);
                //dbContext.SaveChanges();
            }
        }

        private void MainAlumnForm_Load(object sender, EventArgs e)
        {
            //informationsutskickListBox.Items(bm.HämtaInformationsutskickAktiviteterFörAlumn(GLOBALS.AktuellAlumn));

            informationsutskickListBox.Items.Clear();
            aktivitetsBeskrivningTextBox.Text = "";

            foreach (InformationsutskickAlumn informationsutskickAlumn in bm.HämtaInformationsutskickFörAlumn(GLOBALS.AktuellAlumn))
            {
                int Id = informationsutskickAlumn.InformationsutskickID;
                Informationsutskick informationsutskick = bm.unitOfWork.InformationsutskickRepository.GetById(Id);
                int hämtad = -1;
                foreach (InformationsutskickAktivitet informationsutskickAktivitet in bm.HämtaAktivitetMedInformationsutskick(informationsutskick))
                {
                    hämtad = informationsutskickAktivitet.AktivitetID;
                }

                var aktuellAktivitet = bm.unitOfWork.AktivitetRepository.GetById(hämtad);
                informationsutskickListBox.Items.Add(aktuellAktivitet);
                informationsutskickListBox.DisplayMember = "Titel";
                informationsutskickListBox.ValueMember = "AktivitetsID";

            }

            Aktivitet valdAktivitet = (Aktivitet)informationsutskickListBox.SelectedItem;
            if (valdAktivitet != null)
            {
                aktivitetsBeskrivningTextBox.Text = valdAktivitet.Beskrivning;

            }

            //Visa bokade aktiviteter

            foreach (AlumnAktivitetBokning alumnBokning in bm.HämtaBokningFörAlumn(GLOBALS.AktuellAlumn))
            {
                Aktivitet aktivitet = alumnBokning.Aktivitet;

                bokadeAktiviteterListBox.Items.Add(aktivitet);
                bokadeAktiviteterListBox.DisplayMember = "Titel";
                bokadeAktiviteterListBox.ValueMember = "AktivitetsID";

            }

        }

        private void btnBookActivity_Click(object sender, EventArgs e)
        {
            Aktivitet bokadAktivitet = (Aktivitet)informationsutskickListBox.SelectedItem;

            AlumnAktivitetBokning alumnAktivitetBokning = new AlumnAktivitetBokning()
            {
                AlumnID = GLOBALS.AktuellAlumn.AnvändarID,
                //Alumn = GLOBALS.AktuellAlumn,
                AktivitetID = bokadAktivitet.AktivitetsID,
                //Aktivitet = bokadAktivitet
            };
            dbContext.AlumnAktivitet.Add(alumnAktivitetBokning);
            dbContext.SaveChanges();
            MessageBox.Show("Bokningen har skapats");

        }

        private void informationsutskickListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aktivitet valdAktivitet = (Aktivitet)informationsutskickListBox.SelectedItem;
            if (valdAktivitet != null)
            {
                aktivitetsBeskrivningTextBox.Text = valdAktivitet.Beskrivning;

            }
        }

        private void bokadeAktiviteterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aktivitet valdBokadAktivitet = (Aktivitet)bokadeAktiviteterListBox.SelectedItem;
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

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

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
            var selectedKompetensToRemove = (Kompetens)programListBox.SelectedItem;
            bm.TaBortKompetensFrånAlumn(selectedKompetensToRemove, GLOBALS.AktuellAlumn);
            UppdateraKompetenserListBox();
        }
    }
}
