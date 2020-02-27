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
            VäljAktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
                //bm.unitOfWork.AktivitetRepository.GetAll();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";


            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);          
            //bm.unitOfWork.AktivitetRepository.GetById();
            
            ÄndraTitelTxtBox.Text = AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = AktuellAktivitet.Plats;
            StarttidDateTime.Value = AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = AktuellAktivitet.Beskrivning;

            //Fyll alumner och aktivitet på Skapa utskickslista
            alumnCheckedListBox.Items.Clear();
            //comboBoxFilterAlumns.Items.Clear();

            //bm.unitOfWork.AlumnRepository.GetAll())
            foreach (Alumn alumn in bm.HämtaAllaAlumner())
            {
                alumnCheckedListBox.Items.Add(alumn);

            }
            alumnCheckedListBox.ValueMember = "AnvändarID";
            alumnCheckedListBox.DisplayMember = "Förnamn";

            
            AktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            AktivitetComboBox.ValueMember = "AktivitetsID";
            AktivitetComboBox.DisplayMember = "Titel";

            //bm.unitOfWork.ProgramRepository.GetAll();
            comboBoxFilterAlumns.DataSource = bm.HämtaAllaProgram();
            comboBoxFilterAlumns.DisplayMember = "Titel";
            comboBoxFilterAlumns.ValueMember = "Namn";


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
                    AlumnAktivitet = new List<AlumnAktivitetBokning>()

                };

                //bm.unitOfWork.AktivitetRepository.Add(aktivitet);
                bm.LäggTillAktivitet(aktivitet);
                //bm.unitOfWork.Commit();
                bm.Commit();
                MessageBox.Show("Aktiviteten har skapats");

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Aktivitet uppdateradAktivitet = new Aktivitet()
            {
                Titel = ÄndraTitelTxtBox.Text,
                Ansvarig = AnsvarigPersonComboBox.Text,
                Kontaktperson = KontaktpersonComboBox.Text,
                Plats = PlatsÄndraTxtBox.Text,
                Startdatum = StarttidDateTime.Value,
                Slutdatum = SlutdatumÄndraDateTime.Value,
                Beskrivning = BeskrivningÄndraTextBox.Text,
                InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                AlumnAktivitet = new List<AlumnAktivitetBokning>()
            };

            //bm.unitOfWork.AktivitetRepository.GetById();
            Aktivitet aktivitetAttTaBort = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);


            bm.UpdateAktivitet(aktivitetAttTaBort, uppdateradAktivitet);
            //bm.unitOfWork.Commit();
            bm.Commit();

            MessageBox.Show("Aktiviteten " + TitelAktivitetTxtBox.Text + " har Redigerats");
        }

        private void ComboBoxChoosActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bm.unitOfWork.AktivitetRepository.GetById(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);
            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);
            ÄndraTitelTxtBox.Text = AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = AktuellAktivitet.Plats;
            StarttidDateTime.Value = AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = AktuellAktivitet.Beskrivning;
        }

        private void AlumnCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageMakeEmailList_Click(object sender, EventArgs e)
        {

        }

        private void flyttaAlumner_Click(object sender, EventArgs e)
        {
            foreach (Alumn alumn in alumnCheckedListBox.CheckedItems)
            {
                if (!valdaAlumnerListBox.Items.Contains(alumn))
                {
                    List<Alumn> alumner = new List<Alumn>();
                    foreach (Alumn alumn1 in valdaAlumnerListBox.Items)
                    {
                        alumner.Add(alumn1);
                    }
                    alumner.Add(alumn);
                    valdaAlumnerListBox.DataSource = alumner;
                    valdaAlumnerListBox.DisplayMember = "Förnamn";
                    valdaAlumnerListBox.ValueMember = "AnvändarID";
                }
            }
            foreach (Alumn alumn1 in valdaAlumnerListBox.Items)
            {
                if (!alumnCheckedListBox.CheckedItems.Contains(alumn1))
                {
                    List<Alumn> valdaAlumner = new List<Alumn>();
                    foreach (Alumn alumn in valdaAlumnerListBox.Items)
                    {
                        valdaAlumner.Add(alumn);
                    }

                    valdaAlumner.Remove(alumn1);

                    valdaAlumnerListBox.DataSource = valdaAlumner;

                }
            }

            valdaAlumnerListBox.ValueMember = "AnvändarID";
            valdaAlumnerListBox.DisplayMember = "Förnamn";

        }

        private void btnCreateAlumnCSV_Click(object sender, EventArgs e)
        {
            Informationsutskick informationsutskick = new Informationsutskick()
            {
                UtskickDatum = DateTime.Now
            };
            //bm.unitOfWork.InformationsutskickRepository.Add(informationsutskick);
            bm.LäggTillInformationsutskick(informationsutskick);
            bm.Commit();

            InformationsutskickAktivitet informationsutskickAktivitet = new InformationsutskickAktivitet()
            {
                //(bm.unitOfWork.AktivitetRepository.GetById(((Aktivitet)AktivitetComboBox.SelectedItem).AktivitetsID)).AktivitetsID
                AktivitetID = (bm.HämtaAktivitetGenomID(((Aktivitet)AktivitetComboBox.SelectedItem).AktivitetsID)).AktivitetsID,
                InformationsutskickID = informationsutskick.UtskicksID
            };
            //dbContext.InformationsutskickAktivitet.Add(informationsutskickAktivitet);
            bm.LäggTillInformationsutskickAktivitet(informationsutskickAktivitet);
            

            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                InformationsutskickAlumn informationsutskickAlumn = new InformationsutskickAlumn()
                {
                    //(bm.unitOfWork.AlumnRepository.GetById(alumn.AnvändarID)).AnvändarID
                    AlumnID = (bm.HämtaAlumnMedID(alumn.AnvändarID)).AnvändarID,
                    //(bm.unitOfWork.InformationsutskickRepository.GetById(informationsutskick.UtskicksID)).UtskicksID
                    InformationsutskickID = (bm.HämtaInformationsutskickMedID(informationsutskick.UtskicksID)).UtskicksID
                };
                //dbContext.InformationsutskickAlumn.Add(informationsutskickAlumn);
                bm.LäggTillInformationsutskickAlumn(informationsutskickAlumn);
            }

            bm.Commit();
            //dbContext.SaveChanges();

            List<Alumn> alumner = new List<Alumn>();
            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                alumner.Add(alumn);
            }

            bm.SkrivaAlumnAktivitetTillCSVFil(((Aktivitet)AktivitetComboBox.SelectedItem).Titel, alumner);
            MessageBox.Show("Aktivitetens titel och Alumnernas epostadresser har blivit skrivna till CSV Filen!" +
                "Filen hittar du OOSU2AlumnErbjudanden/OOSU2AlumnErbjudanden/PresentationLayer/bin/Debug");

        }

        private void KontaktPersonTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageCreateActivity_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterAlumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnCheckedListBox.Items.Clear();
            foreach (Alumn alumn in AlumnerMedProgramFilter())
            {
                if (alumn != null)
                {

                    alumnCheckedListBox.Items.Add(alumn);
                }
            }

            alumnCheckedListBox.DisplayMember = "Förnamn";
            alumnCheckedListBox.ValueMember = "AnvändarID";
        }
        public List<Alumn> AlumnerMedProgramFilter()
        {
            return bm.HämtaAlumnerMedProgram((ProgramClass)comboBoxFilterAlumns.SelectedItem);
        }

        private void AktivitetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
