using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IPersonal
    {
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        int PersonalID { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }

        ICollection<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }

    }
}
