using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IPersonal
    {
        string Användarnamn { get; set; }
        string Lösenord { get; set; }
    }
}
