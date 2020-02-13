using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IAlumn
    {
        string AnvändarID { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }
    }
}
