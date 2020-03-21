using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFLayer.ViewModel
{
    public class MainAlumnViewModel
    {
        BusinessManager bm = new BusinessManager();

        internal void SparaAnvändarÄndringar(System.Windows.Controls.TextBox ändraFörnamn, System.Windows.Controls.TextBox ändraEfternamn, System.Windows.Controls.TextBox ändraEpostadress)
        {
            if (RegexUtilities.IsValidEmail(ändraEpostadress.Text) == true)
            {
                var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALSWPF.AktuellAlumn.AnvändarID);
                var gammaltFörnamn = InloggadAlumn.Förnamn;
                var gammaltEfternamn = InloggadAlumn.Efternamn;
                var gammalepostadress = InloggadAlumn.Användarnamn;
                bm.UppdateraAlumn(InloggadAlumn.AnvändarID, ändraFörnamn.Text, ändraEfternamn.Text, ändraEpostadress.Text);
                GLOBALSWPF.AktuellAlumn = bm.HämtaAlumnMedID(InloggadAlumn.AnvändarID);
                MessageBox.Show($"Dina uppgifter är nu uppdaterade: " +
                    $"\n{gammaltFörnamn} -> {GLOBALSWPF.AktuellAlumn.Förnamn} " +
                    $"\n{gammaltEfternamn} -> {GLOBALSWPF.AktuellAlumn.Efternamn} " +
                    $"\n{gammalepostadress} -> {GLOBALSWPF.AktuellAlumn.Användarnamn}");
            }
            else
            {
                MessageBox.Show("Var vänlig fyll i en giltig mailadress");
            }
        }
    }
}
