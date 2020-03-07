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
    public partial class CreateUserForm : Form
    {
        BusinessManager bm = new BusinessManager();
        
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (AnvändarnamnTxtBox.Text == "" || LösenordTxtBox.Text == "" || FörnamnTxtBox.Text == "" || EfternamnTxtBox.Text == "")
                MessageBox.Show("Var vänlig fyll i alla textrutor");
            else
            {
                if (RegexUtilities.IsValidEmail(AnvändarnamnTxtBox.Text) == true)
                {

                    if (radioButtonAlumn.Checked == true)
                    {
                        Alumn alumn = new Alumn()
                        {
                            Användarnamn = AnvändarnamnTxtBox.Text,
                            Lösenord = LösenordTxtBox.Text,
                            Förnamn = FörnamnTxtBox.Text,
                            Efternamn = EfternamnTxtBox.Text
                        };
                        bm.LäggTillAlumn(alumn);
                        MessageBox.Show("Alumnkonto har skapats");

                        DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("Var vänlig fyll i en giltig mailadress");
                }
                if (radioButtonPersonal.Checked == true)
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

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
