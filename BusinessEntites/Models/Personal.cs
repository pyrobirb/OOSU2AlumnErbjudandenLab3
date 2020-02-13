using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;

namespace BusinessEntites.Models
{
    public class Personal : IPersonal
    {
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
    }
}
