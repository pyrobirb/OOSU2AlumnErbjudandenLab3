using System.Collections.Generic;

namespace BusinessEntites.Models
{
    public interface IAktivaAktiviteter
    {
        List<Aktivitet> Aktiviteter { get; set; }
        List<Alumn> Alumner { get; set; }

        List<Aktivitet> HämtaAktiviteter();
    }
}