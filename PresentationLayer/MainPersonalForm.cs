﻿using System;
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
using ProgramClass = BusinessEntites.Models.ProgramDTO;

namespace PresentationLayer
{
    public partial class MainPersonalForm : Form
    {
        DatabaseContext dbContext = new DatabaseContext();
        BusinessManager bm = new BusinessManager();
        public MainPersonalForm()
        {
            InitializeComponent();

            if (!(GLOBALS.AktuellPersonal.Användarnamn == "SuperAdmin" && GLOBALS.AktuellPersonal.PersonalID == 1))
            {
                skapaPersKontoSupAdmLbel.Visible = false;
                createPersonalAccBtn.Visible = false;
            }
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";

            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((AktivitetDTO)VäljAktivitetComboBox.SelectedItem).AktivitetsID);          
            
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

            List<AlumnDTO> AktuellaAnmälda = bm.HämtaAnmälningarGenomAktivitetsID(((AktivitetDTO)VäljAktivitetSeAnmälancomboBox.SelectedItem).AktivitetsID);

            AnmäldaAlumnerDataGridView.DataSource = AktuellaAnmälda;
            if (AnmäldaAlumnerDataGridView.ColumnCount > 0)
            {
                AnmäldaAlumnerDataGridView.Columns[0].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[1].DisplayIndex = 5;
                AnmäldaAlumnerDataGridView.Columns[2].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[5].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[6].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[7].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[8].Visible = false;
                AnmäldaAlumnerDataGridView.Columns[9].Visible = false;
            }


            //Fyll alumner och aktivitet på Skapa utskickslista
            alumnCheckedListBox.Items.Clear();

            foreach (AlumnDTO alumn in bm.HämtaAllaAlumner())
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

            //Fyll på alumner i mailinglistan

            AlumnMaillistCheckedListBox.Items.Clear();

            foreach (AlumnDTO alumn in bm.HämtaAllaAlumner())
            {
                AlumnMaillistCheckedListBox.Items.Add(alumn);

            }
            AlumnMaillistCheckedListBox.ValueMember = "AnvändarID";
            AlumnMaillistCheckedListBox.DisplayMember = "Förnamn";

            FilterAlumnMailComboBox.DataSource = bm.HämtaAllaProgram();
            FilterAlumnMailComboBox.DisplayMember = "Titel";
            FilterAlumnMailComboBox.ValueMember = "Namn";

            //Fyll på utgå från gamla utskickslistor

            GamlaListorComboBox.DataSource = bm.HämtaAllaInformationsutskick();
            GamlaListorComboBox.DisplayMember = "UtskicksNamn";
            GamlaListorComboBox.ValueMember = "UtskicksID";


            //Fyll på utskickslistor på gamla utskickslistor

            //MailingListaALumnerlistBox.DataSource = bm.HämtaAllaInformationsutskick();
            //MailingListaALumnerlistBox.DisplayMember = "UtskicksNamn";
            //MailingListaALumnerlistBox.ValueMember = "UtskicksID";

            //Fyll på maillistor

            GamlaListorComboBox.DataSource = bm.HämtaAllaMaillistor();
            GamlaListorComboBox.DisplayMember = "Maillistanamn";
            GamlaListorComboBox.ValueMember = "MaillistaID";


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
                AktivitetDTO aktivitet = new AktivitetDTO()
                {
                    Titel = TitelAktivitetTxtBox.Text,
                    Ansvarig = AnsvarigPersonTxtBox.Text,
                    Kontaktperson = KontaktPersonTxtBox.Text,
                    Plats = PlatsTxtBox.Text,
                    Startdatum = StarttidDateTimePicker.Value,
                    Slutdatum = SluttidDateTimePicker.Value,
                    Beskrivning = BeskrivningTextBox.Text,
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitetDTO>(),
                    AlumnAktivitet = new List<AlumnAktivitetBokningDTO>()

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
            AktivitetDTO uppdateradAktivitet = new AktivitetDTO()
            {
                Titel = ÄndraTitelTxtBox.Text,
                Ansvarig = AnsvarigPersonComboBox.Text,
                Kontaktperson = KontaktpersonComboBox.Text,
                Plats = PlatsÄndraTxtBox.Text,
                Startdatum = StarttidDateTime.Value,
                Slutdatum = SlutdatumÄndraDateTime.Value,
                Beskrivning = BeskrivningÄndraTextBox.Text,
                InformationsutskickAktivitet = new List<InformationsutskickAktivitetDTO>(),
                AlumnAktivitet = new List<AlumnAktivitetBokningDTO>()
            };

            AktivitetDTO aktivitetAttTaBort = bm.HämtaAktivitetGenomID(((AktivitetDTO)VäljAktivitetComboBox.SelectedItem).AktivitetsID);


            bm.UpdateAktivitet(aktivitetAttTaBort, uppdateradAktivitet);
            bm.Commit();

            MessageBox.Show("Aktiviteten " + TitelAktivitetTxtBox.Text + " har Redigerats");
            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.HämtaAllaAktiviteter();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetsID";

            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((AktivitetDTO)VäljAktivitetComboBox.SelectedItem).AktivitetsID);

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
            var AktuellAktivitet = bm.HämtaAktivitetGenomID(((AktivitetDTO)VäljAktivitetComboBox.SelectedItem).AktivitetsID);
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
            foreach (AlumnDTO alumn in alumnCheckedListBox.CheckedItems)
            {
                if (!valdaAlumnerListBox.Items.Contains(alumn))
                {
                    List<AlumnDTO> alumner = new List<AlumnDTO>();
                    foreach (AlumnDTO alumn1 in valdaAlumnerListBox.Items)
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
            InformationsutskickDTO informationsutskick = new InformationsutskickDTO()
            {
                UtskicksNamn = NamnMailListaTextBox.Text,
                UtskickDatum = DateTime.Now
            };
            bm.LäggTillInformationsutskick(informationsutskick);
            bm.Commit();

            InformationsutskickAktivitetDTO informationsutskickAktivitet = new InformationsutskickAktivitetDTO()
            {
                AktivitetID = (bm.HämtaAktivitetGenomID(((AktivitetDTO)AktivitetComboBox.SelectedItem).AktivitetsID)).AktivitetsID,
                InformationsutskickID = informationsutskick.UtskicksID
            };
            bm.LäggTillInformationsutskickAktivitet(informationsutskickAktivitet);
            

            foreach (AlumnDTO alumn in valdaAlumnerListBox.Items)
            {
                InformationsutskickAlumnDTO informationsutskickAlumn = new InformationsutskickAlumnDTO()
                {
                    AlumnID = (bm.HämtaAlumnMedID(alumn.AnvändarID)).AnvändarID,
                    InformationsutskickID = (bm.HämtaInformationsutskickMedID(informationsutskick.UtskicksID)).UtskicksID
                };
                bm.LäggTillInformationsutskickAlumn(informationsutskickAlumn);
            }

            bm.Commit();

            List<AlumnDTO> alumner = new List<AlumnDTO>();
            foreach (AlumnDTO alumn in valdaAlumnerListBox.Items)
            {
                alumner.Add(alumn);
            }

            //bm.SkrivaAlumnAktivitetTillCSVFil(((Aktivitet)AktivitetComboBox.SelectedItem).Titel, alumner);
            MessageBox.Show("Aktiviteten har nu blivit publicerad hos alumnerna."//"Aktivitetens titel och Alumnernas epostadresser har blivit skrivna till CSV Filen!" +
                //"Filen hittar du OOSU2AlumnErbjudanden/OOSU2AlumnErbjudanden/PresentationLayer/bin/Debug/CSV/"
                );
            //Tömmer sätt namn på Utskicksboxen och ValdaAlumner samt fyller i gamla listorboxen. 
            NamnMailListaTextBox.Clear();

            //GamlaListorComboBox.DataSource = bm.HämtaAllaMaillistor();
            //GamlaListorComboBox.DisplayMember = "Maillistanamn";
            //GamlaListorComboBox.ValueMember = "MaillistaID";


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
                IEnumerable<AlumnDTO> hämtadeAlumner = bm.HämtaAllaAlumner();
                foreach (AlumnDTO alumn in hämtadeAlumner)
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
                foreach (AlumnDTO alumn in AlumnerMedProgramFilter())
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
        public List<AlumnDTO> AlumnerMedProgramFilter()
        {
            return bm.HämtaAlumnerMedProgram((ProgramClass)comboBoxFilterAlumns.SelectedItem);
        }

        private void AktivitetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VäljAktivitetSeAnmälancomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            AnmäldaAlumnerDataGridView.DataSource = bm.HämtaAnmälningarGenomAktivitetsID(((AktivitetDTO)VäljAktivitetSeAnmälancomboBox.SelectedItem).AktivitetsID);


        }

        private void TaBortAlumnBtn_Click(object sender, EventArgs e)
        {
            valdaAlumnerListBox.BeginUpdate();
            ArrayList vSelectedItems = new ArrayList(valdaAlumnerListBox.SelectedItems);
            ArrayList itemsToStore = new ArrayList(valdaAlumnerListBox.Items);
            foreach (AlumnDTO item in vSelectedItems)
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
            if (GamlaListorComboBox.SelectedItem != null)
            {
                List<AlumnDTO> Alumner = bm.HämtaAlumnerFrånLista(((InformationsutskickDTO)GamlaListorComboBox.SelectedItem).UtskicksID);
                MailingListaALumnerlistBox.DataSource = Alumner;
                MailingListaALumnerlistBox.DisplayMember = "Förnamn";
                MailingListaALumnerlistBox.ValueMember = "AnvändarID";
            }

        }

        private void LaddaGamlaAlumnerFrånListabtn_Click(object sender, EventArgs e)
        {
            if (GamlaListorComboBox.SelectedItem != null)
            {
                List<AlumnDTO> Alumner2 = bm.HämtaAlumnerFrånLista(((InformationsutskickDTO)GamlaListorComboBox.SelectedItem).UtskicksID);
                valdaAlumnerListBox.DataSource = Alumner2;
                valdaAlumnerListBox.DisplayMember = "Förnamn";
                valdaAlumnerListBox.ValueMember = "AnvändarID";              
            }
        }

        private void valdaAlumnerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VäljALumnMailBtn_Click(object sender, EventArgs e)
        {
            foreach (AlumnDTO alumn in AlumnMaillistCheckedListBox.CheckedItems)
            {
                if (!MailingListaALumnerlistBox.Items.Contains(alumn))
                {
                    List<AlumnDTO> alumner = new List<AlumnDTO>();
                    foreach (AlumnDTO alumn1 in MailingListaALumnerlistBox.Items)
                    {
                        alumner.Add(alumn1);
                    }
                    alumner.Add(alumn);
                    MailingListaALumnerlistBox.DataSource = alumner;
                    MailingListaALumnerlistBox.DisplayMember = "Förnamn";
                    MailingListaALumnerlistBox.ValueMember = "AnvändarID";
                }
            }

            MailingListaALumnerlistBox.ValueMember = "AnvändarID";
            MailingListaALumnerlistBox.DisplayMember = "Förnamn";

            foreach (int i in AlumnMaillistCheckedListBox.CheckedIndices)
            {
                AlumnMaillistCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void FilterAlumnMailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterAlumnMailComboBox.SelectedIndex == 0)
            {
                AlumnMaillistCheckedListBox.Items.Clear();
                IEnumerable<AlumnDTO> hämtadeAlumner = bm.HämtaAllaAlumner();
                foreach (AlumnDTO alumn in hämtadeAlumner)
                {
                    if (alumn != null)
                    {

                        AlumnMaillistCheckedListBox.Items.Add(alumn);
                    }
                }
            }
            else
            {
                AlumnMaillistCheckedListBox.Items.Clear();
                foreach (AlumnDTO alumn in AlumnerMedProgramFilterMail())
                {
                    if (alumn != null)
                    {

                        AlumnMaillistCheckedListBox.Items.Add(alumn);
                    }
                }
            }

            AlumnMaillistCheckedListBox.DisplayMember = "Förnamn";
            AlumnMaillistCheckedListBox.ValueMember = "AnvändarID";
        }
        public List<AlumnDTO> AlumnerMedProgramFilterMail()
        {
            return bm.HämtaAlumnerMedProgram((ProgramClass)FilterAlumnMailComboBox.SelectedItem);
        }

        private void SkapaCSVochMailListaBtn_Click(object sender, EventArgs e)
        {
            SkapaMaillista();
        }

        private void SkapaMaillista()
        {
            if (NamnMailListaTextBox.Text == "")
            {
                MessageBox.Show("Du måste namnge listan.");
            }                
            else if (MailingListaALumnerlistBox.Items.Count < 1)
            {
                MessageBox.Show("Du måste lägga till minst en alumn i listan valda alumner.");
            }
            else
            {

                MaillistaDTO maillista = new MaillistaDTO()
                {
                    MaillistaNamn = NamnMailListaTextBox.Text,
                    AlumnMaillistor = new List<AlumnMaillistaDTO>()
                };

                bm.LäggTillMaillista(maillista);
                bm.Commit();

                foreach (AlumnDTO alumn in MailingListaALumnerlistBox.Items)
                {
                    AlumnMaillistaDTO alumnMaillista = new AlumnMaillistaDTO()
                    {
                        MaillistaID = bm.HämtaSenasteMaillista().MaillistaID,
                        AlumnID = (bm.HämtaAlumnMedID(alumn.AnvändarID)).AnvändarID
                    };
                    bm.LäggTillAlumnMaillista(alumnMaillista);
                }

                bm.Commit();

                List<AlumnDTO> alumner = new List<AlumnDTO>();
                foreach (AlumnDTO alumn in valdaAlumnerListBox.Items)
                {
                    alumner.Add(alumn);
                }

                bm.SkrivaAlumnAktivitetTillCSVFil(NamnMailListaTextBox.Text, alumner);
                MessageBox.Show("Maillistans namn och Alumnernas epostadresser har blivit skrivna till CSV Filen!" +
                                 "Filen hittar du OOSU2AlumnErbjudanden/OOSU2AlumnErbjudanden/WPFLayer/bin/Debug");
                //Tömmer sätt namn på Utskicksboxen och ValdaAlumner samt fyller i gamla listorboxen. 
                NamnMailListaTextBox.Clear();


                GamlaListorComboBox.DataSource = bm.HämtaAllaMaillistor();
                GamlaListorComboBox.DisplayMember = "Maillistanamn";
                GamlaListorComboBox.ValueMember = "MaillistaID";

                MailingListaALumnerlistBox.BeginUpdate();
                MailingListaALumnerlistBox.DataSource = new ArrayList();
                MailingListaALumnerlistBox.DisplayMember = "Förnamn";
                MailingListaALumnerlistBox.ValueMember = "AnvändarID";
                MailingListaALumnerlistBox.EndUpdate();

                MessageBox.Show("Maillistan har skapats");
                
            }
        }

        private void TaBortAlumnMailBtn_Click(object sender, EventArgs e)
        {
            MailingListaALumnerlistBox.BeginUpdate();
            ArrayList vSelectedItems = new ArrayList(MailingListaALumnerlistBox.SelectedItems);
            ArrayList itemsToStore = new ArrayList(MailingListaALumnerlistBox.Items);
            foreach (AlumnDTO item in vSelectedItems)
            {
                itemsToStore.Remove(item);
            }
            MailingListaALumnerlistBox.DataSource = itemsToStore;
            MailingListaALumnerlistBox.DisplayMember = "Förnamn";
            MailingListaALumnerlistBox.ValueMember = "AnvändarID";
            MailingListaALumnerlistBox.EndUpdate();
        }

        private void LaddaGamlaAlumnerFrånListabtn_Click_1(object sender, EventArgs e)
        {
            if (GamlaListorComboBox.SelectedItem != null)
            {
                List<AlumnDTO> Alumner3 = bm.HämtaAlumnerFrånMailLista(((MaillistaDTO)GamlaListorComboBox.SelectedItem).MaillistaID);
                MailingListaALumnerlistBox.DataSource = Alumner3;
                MailingListaALumnerlistBox.DisplayMember = "Förnamn";
                MailingListaALumnerlistBox.ValueMember = "AnvändarID";
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void ShowForm(Form form)
        {
            Visible = !Visible;
            if (form.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void createPersonalAccBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new CreatePersonalForm());
        }

        private void tabCreateMailingList_Click(object sender, EventArgs e)
        {

        }

        private void AnmäldaAlumnerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
