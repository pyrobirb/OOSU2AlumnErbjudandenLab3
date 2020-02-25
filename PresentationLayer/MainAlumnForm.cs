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

        }

        private void MainAlumnForm_Load(object sender, EventArgs e)
        {
            //informationsutskickListBox.Items(bm.HämtaInformationsutskickAktiviteterFörAlumn(GLOBALS.AktuellAlumn));

            informationsutskickListBox.Items.Clear();
            aktivitetsBeskrivningTextBox.Text = "";

            foreach (Informationsutskick informationsutskick in bm.HämtaInformationsutskickFörAlumn(GLOBALS.AktuellAlumn))
            {
                //ta fram aktivitet från infoutskick
                informationsutskickListBox.Items.Add(informationsutskick);
            }

            //alumnCheckedListBox.Items.Clear();
            //AktivitetComboBox.Items.Clear();

            //foreach (Alumn alumn in bm.unitOfWork.AlumnRepository.GetAll())
            //{
            //    alumnCheckedListBox.Items.Add(alumn);

            //}
            //alumnCheckedListBox.ValueMember = "AnvändarID";
            //alumnCheckedListBox.DisplayMember = "Förnamn";
        }

        private void btnBookActivity_Click(object sender, EventArgs e)
        {

        }

        private void informationsutskickListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
