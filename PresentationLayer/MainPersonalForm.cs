using System;
using System.Collections;
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


            if (!(GLOBALS.AktuellPersonal.PersonalID == 1 && GLOBALS.AktuellPersonal.Användarnamn == "SuperAdmin"))
            {
                skapaPersonalBtn.Visible = false;
                skapaPersonalLabel.Visible = false;
            }
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";

            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);          
            
            ÄndraTitelTxtBox.Text = AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = AktuellAktivitet.Plats;
            StarttidDateTime.Value = AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = AktuellAktivitet.Beskrivning;

            //Fyll se anmälningar
            VäljAktivitetSeAnmälancomboBox.DataSource = bm.HämtaAllaAktiviteter();
            VäljAktivitetSeAnmälancomboBox.DisplayMember = "Titel";
            VäljAktivitetSeAnmälancomboBox.ValueMember = "AktivitetsID";

            List<Alumn> AktuellaAnmälda = bm.HämtaAnmälningarGenomAktivitetsID(((Aktivitet)VäljAktivitetSeAnmälancomboBox.SelectedItem).AktivitetsID);

            AnmäldaAlumnerDataGridView.DataSource = AktuellaAnmälda;
            if (AnmäldaAlumnerDataGridView.ColumnCount > 0)
            {
                AnmäldaAlumnerDataGridView.Columns[0].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[1].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[2].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[7].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[8].Visible = false;
            }


            //Fyll alumner och aktivitet på Skapa utskickslista
            alumnCheckedListBox.Items.Clear();

            foreach (Alumn alumn in bm.HämtaAllaAlumner())
            {
                alumnCheckedListBox.Items.Add(alumn);

            }
            alumnCheckedListBox.ValueMember = "AnvändarID";
            alumnCheckedListBox.DisplayMember = "Förnamn";

            
            AktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            AktivitetComboBox.ValueMember = "AktivitetsID";
            AktivitetComboBox.DisplayMember = "Titel";

            comboBoxFilterAlumns.DataSource = bm.HämtaAllaProgram();
            comboBoxFilterAlumns.DisplayMember = "Titel";
            comboBoxFilterAlumns.ValueMember = "Namn";

            //Fyll på utgå från gamla utskickslistor

            GamlaListorComboBox.DataSource = bm.HämtaAllaInformationsutskick();
            GamlaListorComboBox.DisplayMember = "UtskicksNamn";
            GamlaListorComboBox.ValueMember = "UtskicksID";


            //Fyll på utskickslistor på gamla utskickslistor

            VäljGammalUtskicksListacomboBox.DataSource = bm.HämtaAllaInformationsutskick();
            VäljGammalUtskicksListacomboBox.DisplayMember = "UtskicksNamn";
            VäljGammalUtskicksListacomboBox.ValueMember = "UtskicksID";


        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateActivity_Click(object sender, EventArgs e)
        {
            SkapaAktivitet();
        }

        private void SkapaAktivitet()
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

                bm.LäggTillAktivitet(aktivitet);
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

            Aktivitet aktivitetAttTaBort = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);


            bm.UpdateAktivitet(aktivitetAttTaBort, uppdateradAktivitet);
            bm.Commit();

            MessageBox.Show("Aktiviteten " + TitelAktivitetTxtBox.Text + " har Redigerats");
            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";

            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetsID);

            ÄndraTitelTxtBox.Text = AktuellAktivitet.Titel;
            AnsvarigPersonComboBox.Text = AktuellAktivitet.Ansvarig;
            KontaktpersonComboBox.Text = AktuellAktivitet.Kontaktperson;
            PlatsÄndraTxtBox.Text = AktuellAktivitet.Plats;
            StarttidDateTime.Value = AktuellAktivitet.Startdatum;
            SlutdatumÄndraDateTime.Value = AktuellAktivitet.Slutdatum;
            BeskrivningÄndraTextBox.Text = AktuellAktivitet.Beskrivning;
        }

        private void VäljAktivitetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //Vad gör det här bortkommenterade stycket??
            //foreach (Alumn alumn1 in valdaAlumnerListBox.Items)
            //{
            //    if (!alumnCheckedListBox.CheckedItems.Contains(alumn1))
            //    {
            //        List<Alumn> valdaAlumner = new List<Alumn>();
            //        foreach (Alumn alumn in valdaAlumnerListBox.Items)
            //        {
            //            valdaAlumner.Add(alumn);
            //        }

            //        valdaAlumner.Remove(alumn1);

            //        valdaAlumnerListBox.DataSource = valdaAlumner;

            //    }
            //}

            valdaAlumnerListBox.ValueMember = "AnvändarID";
            valdaAlumnerListBox.DisplayMember = "Förnamn";

            foreach (int i in alumnCheckedListBox.CheckedIndices)
            {
                alumnCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void btnCreateAlumnCSV_Click(object sender, EventArgs e)
        {
            Informationsutskick informationsutskick = new Informationsutskick()
            {
                UtskicksNamn = NamnUtskicksListaTextBox.Text,
                UtskickDatum = DateTime.Now
            };
            bm.LäggTillInformationsutskick(informationsutskick);
            bm.Commit();

            InformationsutskickAktivitet informationsutskickAktivitet = new InformationsutskickAktivitet()
            {
                AktivitetID = (bm.HämtaAktivitetGenomID(((Aktivitet)AktivitetComboBox.SelectedItem).AktivitetsID)).AktivitetsID,
                InformationsutskickID = informationsutskick.UtskicksID
            };
            bm.LäggTillInformationsutskickAktivitet(informationsutskickAktivitet);
            

            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                InformationsutskickAlumn informationsutskickAlumn = new InformationsutskickAlumn()
                {
                    AlumnID = (bm.HämtaAlumnMedID(alumn.AnvändarID)).AnvändarID,
                    InformationsutskickID = (bm.HämtaInformationsutskickMedID(informationsutskick.UtskicksID)).UtskicksID
                };
                bm.LäggTillInformationsutskickAlumn(informationsutskickAlumn);
            }

            bm.Commit();

            List<Alumn> alumner = new List<Alumn>();
            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                alumner.Add(alumn);
            }

            bm.SkrivaAlumnAktivitetTillCSVFil(((Aktivitet)AktivitetComboBox.SelectedItem).Titel, alumner);
            MessageBox.Show("Aktivitetens titel och Alumnernas epostadresser har blivit skrivna till CSV Filen!" +
                "Filen hittar du OOSU2AlumnErbjudanden/OOSU2AlumnErbjudanden/PresentationLayer/bin/Debug");
            //Tömmer sätt namn på Utskicksboxen och ValdaAlumner samt fyller i gamla listorboxen. 
            NamnUtskicksListaTextBox.Clear();

            GamlaListorComboBox.DataSource = bm.HämtaAllaInformationsutskick();
            GamlaListorComboBox.DisplayMember = "UtskicksNamn";
            GamlaListorComboBox.ValueMember = "UtskicksID";

            valdaAlumnerListBox.BeginUpdate();
            valdaAlumnerListBox.DataSource = new ArrayList();
            valdaAlumnerListBox.DisplayMember = "Förnamn";
            valdaAlumnerListBox.ValueMember = "AnvändarID";
            valdaAlumnerListBox.EndUpdate();

        }

        private void KontaktPersonTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageCreateActivity_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterAlumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterAlumns.SelectedIndex == 0 )
            {
                alumnCheckedListBox.Items.Clear();
                IEnumerable<Alumn> hämtadeAlumner = bm.HämtaAllaAlumner();
                foreach (Alumn alumn in hämtadeAlumner)
                {
                    if (alumn != null)
                    {

                        alumnCheckedListBox.Items.Add(alumn);
                    }
                }
            }
            else
            {
                alumnCheckedListBox.Items.Clear();
                foreach (Alumn alumn in AlumnerMedProgramFilter())
                {
                    if (alumn != null)
                    {

                        alumnCheckedListBox.Items.Add(alumn);
                    }
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

        private void VäljAktivitetSeAnmälancomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            AnmäldaAlumnerDataGridView.DataSource = bm.HämtaAnmälningarGenomAktivitetsID(((Aktivitet)VäljAktivitetSeAnmälancomboBox.SelectedItem).AktivitetsID);


        }

        private void TaBortAlumnBtn_Click(object sender, EventArgs e)
        {
            valdaAlumnerListBox.BeginUpdate();
            ArrayList vSelectedItems = new ArrayList(valdaAlumnerListBox.SelectedItems);
            ArrayList itemsToStore = new ArrayList(valdaAlumnerListBox.Items);
            foreach (Alumn item in vSelectedItems)
            {
                itemsToStore.Remove(item);
            }
            valdaAlumnerListBox.DataSource = itemsToStore;
            valdaAlumnerListBox.DisplayMember = "Förnamn";
            valdaAlumnerListBox.ValueMember = "AnvändarID";
            valdaAlumnerListBox.EndUpdate();
        }

        private void VäljGammalUtskicksListacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VäljGammalUtskicksListacomboBox.SelectedItem != null)
            {
                List<Alumn> Alumner = bm.HämtaAlumnerFrånLista(((Informationsutskick)VäljGammalUtskicksListacomboBox.SelectedItem).UtskicksID);
                GammalListaMedALumnerlistBox.DataSource = Alumner;
                GammalListaMedALumnerlistBox.DisplayMember = "Förnamn";
                GammalListaMedALumnerlistBox.ValueMember = "AnvändarID";
            }
        }

        private void LaddaGamlaAlumnerFrånListabtn_Click(object sender, EventArgs e)
        {
            if (GamlaListorComboBox.SelectedItem != null)
            {
                List<Alumn> Alumner2 = bm.HämtaAlumnerFrånLista(((Informationsutskick)GamlaListorComboBox.SelectedItem).UtskicksID);
                valdaAlumnerListBox.DataSource = Alumner2;
                valdaAlumnerListBox.DisplayMember = "Förnamn";
                valdaAlumnerListBox.ValueMember = "AnvändarID";              
            }
        }

        private void valdaAlumnerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowForm(Form form)
        {
            Visible = !Visible;
            if (form.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void skapaPersonalBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new CreatePersonalForm());
        }
    }
}
