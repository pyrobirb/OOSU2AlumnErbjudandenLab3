using BusinessEntites.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CreatePersonalForm : Form
    {
        BusinessManager bm = new BusinessManager();
        public CreatePersonalForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EfternamnTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FörnamnTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (AnvändarnamnTxtBox.Text == "" || LösenordTxtBox.Text == "" || FörnamnTxtBox.Text == "" || EfternamnTxtBox.Text == "")
                MessageBox.Show("Var vänlig fyll i alla textrutor");
            else
            {

            Personal personal = new Personal()
            {
                Användarnamn = AnvändarnamnTxtBox.Text,
                Lösenord = LösenordTxtBox.Text,
                Förnamn = FörnamnTxtBox.Text,
                Efternamn = EfternamnTxtBox.Text
            };
            bm.LäggTillPersonal(personal);
            MessageBox.Show("Personalkonto har skapats");

            DialogResult = DialogResult.OK;
            }
        }

        private void LösenordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AnvändarnamnTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
