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
    public partial class MainAlumnForm : Form
    {
        DatabaseContext dbContext = new DatabaseContext();
        BusinessManager bm = new BusinessManager();
        public MainAlumnForm()
        {
            InitializeComponent();
        }

        private void tabControlAlumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visa bokade aktiviteter

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
    }
}
