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

namespace PresentationLayer
{
    public partial class MainPersonalForm : Form
    {
        DatabaseContext dbContext = new DatabaseContext();
        BusinessManager bm = new BusinessManager();
        public MainPersonalForm()
        {
            InitializeComponent();
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.unitOfWork.AktivitetRepository.GetAll();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";

            //Här och när man byter aktivitet i drop downen
            GLOBALS.AktuellAktivitet = bm.unitOfWork.AktivitetRepository.GetById(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);
            ÄndraTitelTxtBox.Text = GLOBALS.AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = GLOBALS.AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = GLOBALS.AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = GLOBALS.AktuellAktivitet.Plats;
            StarttidDateTime.Value = GLOBALS.AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = GLOBALS.AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = GLOBALS.AktuellAktivitet.Beskrivning;

            //Fyll alumner och aktivitet på Skapa utskickslista
            AlumnCheckedListBox.DataSource = bm.unitOfWork.AlumnRepository.GetAll();
            VäljAktivitetComboBox.ValueMember = "AnvändarID";
            VäljAktivitetComboBox.DisplayMember = "Förnamn";
            

            //Här och när man byter aktivitet i drop downen
            //GLOBALS.AktuellaAlumner = bm.unitOfWork.AlumnRepository.GetById(((ICollection<Alumn>)AlumnCheckedListBox.SelectedItems).AnvändarID);
            


        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateActivity_Click(object sender, EventArgs e)
        {
            if (TitelAktivitetTxtBox.Text == "" || AnsvarigPersonTxtBox.Text == "" || KontaktPersonTxtBox.Text == "" || PlatsTxtBox.Text == "" || BeskrivningTextBox.Text == "")
                MessageBox.Show("Var vänlig fyll i alla textrutor");
            else
            {
                Aktivitet aktivitet = new Aktivitet()
                {
                    Titel = TitelAktivitetTxtBox.Text,
                    Ansvarig = AnsvarigPersonTxtBox.Text,
                    Kontaktperson = KontaktPersonTxtBox.Text,
                    Plats = PlatsTxtBox.Text,
                    Startdatum = StarttidDateTimePicker.Value,
                    Slutdatum = SluttidDateTimePicker.Value,
                    Beskrivning = BeskrivningTextBox.Text,
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                    AlumnAktivitet = new List<AlumnAktivitet>()

                };

                bm.unitOfWork.AktivitetRepository.Add(aktivitet);
                bm.unitOfWork.Commit();
                MessageBox.Show("Aktiviteten har skapats");

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxChoosActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GLOBALS.AktuellAktivitet = bm.unitOfWork.AktivitetRepository.GetById(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);
            ÄndraTitelTxtBox.Text = GLOBALS.AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = GLOBALS.AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = GLOBALS.AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = GLOBALS.AktuellAktivitet.Plats;
            StarttidDateTime.Value = GLOBALS.AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = GLOBALS.AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = GLOBALS.AktuellAktivitet.Beskrivning;
        }

        private void AlumnCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
