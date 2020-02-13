using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IAktivitet
    {
        string AktivitetsID { get; set; }
        string Titel { get; set; }
        string Kontaktperson { get; set; }
        string Ansvarig { get; set; }
        string Plats { get; set; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        string Beskrivning { get; set; }
    }
}
