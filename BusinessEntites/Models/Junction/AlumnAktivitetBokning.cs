using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnAktivitetBokning
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int AktivitetID { get; set; }
        public virtual Aktivitet Aktivitet { get; set; }

    }
}
