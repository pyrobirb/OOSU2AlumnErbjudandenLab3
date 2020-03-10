﻿using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IAktivitetDTO
    {
        int AktivitetsID { get; set; }
        string Titel { get; set; }
        string Kontaktperson { get; set; }
        string Ansvarig { get; set; }
        string Plats { get; set; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        string Beskrivning { get; set; }
        ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

    }
}
