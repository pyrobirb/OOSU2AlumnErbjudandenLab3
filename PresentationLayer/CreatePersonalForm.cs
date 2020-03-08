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

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

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
    }
}
