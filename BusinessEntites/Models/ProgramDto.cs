using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;
using BusinessEntites.Models.Junction;

namespace BusinessEntites.Models
{
    public class ProgramDTO : IProgramDTO
    {
        [Key]
        public int ProgramID { get; set; }
        public string Namn { get; set; }

        
        public virtual ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        
    }
}
