using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IInformationsutskick
    {
        string UtskicksID { get; set; }
        DateTime UtskickDatum { get; set; }

        ICollection<Alumn> Utskickslista { get; set; }
    }
}
