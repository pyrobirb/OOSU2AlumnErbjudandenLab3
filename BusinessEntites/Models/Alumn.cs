using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models
{
    public class Alumn
    {
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public List<string> Kompetenser { get; set; }
    }
}
