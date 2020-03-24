﻿using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepository
{
    public class AktivitetRepository : Repository<AktivitetDTO>, IAktivitetRepository
    {
        public void UpdateAktivitet(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet)
        {

            var db = new DatabaseContext();
            var akt = db.Aktiviteter.Find(aktivitet.AktivitetsID);




            this.Context.Aktiviteter.Attach(aktivitet);
            aktivitet.Titel = nyaktivitet.Titel;
            aktivitet.Ansvarig = nyaktivitet.Ansvarig;
            aktivitet.Kontaktperson = nyaktivitet.Kontaktperson;
            aktivitet.Plats = nyaktivitet.Plats;
            aktivitet.Startdatum = nyaktivitet.Startdatum;
            aktivitet.Slutdatum = nyaktivitet.Slutdatum;
            aktivitet.Beskrivning = nyaktivitet.Beskrivning;

            this.Context.SaveChanges();
        }

        public void UpdateAktivitetWPF(AktivitetDTO aktivitet, AktivitetDTO nyaktivitet)
        {

            var db = new DatabaseContext();
            var akt = db.Aktiviteter.Find(aktivitet.AktivitetsID);


            akt.Titel = nyaktivitet.Titel;
            akt.Ansvarig = nyaktivitet.Ansvarig;
            akt.Kontaktperson = nyaktivitet.Kontaktperson;
            akt.Plats = nyaktivitet.Plats;
            akt.Startdatum = nyaktivitet.Startdatum;
            akt.Slutdatum = nyaktivitet.Slutdatum;
            akt.Beskrivning = nyaktivitet.Beskrivning;

            db.SaveChanges();

        }



        public IQueryable<AlumnAktivitetBokningDTO> HämtaBokningFörAlumn (AlumnDTO inloggadAlumn)
        {
            var db = new DatabaseContext();
            return db.AlumnAktivitet.Where(x => x.Alumn == inloggadAlumn);
        }

        public void TaBortAktivitetFrånAlumn(AktivitetDTO aktivitet, AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnAktivitet.Where(x => x.AlumnID == aktuellAlumn.AnvändarID && x.AktivitetID == aktivitet.AktivitetsID).Select(x => x).FirstOrDefault();
            db.AlumnAktivitet.Remove(query);
            db.SaveChanges();
        }

        public void LäggTillAlumnAktivitetBokning(AlumnAktivitetBokningDTO alumnAktivitetBokning)
        {
            var db = new DatabaseContext();
            db.AlumnAktivitet.Add(alumnAktivitetBokning);
            db.SaveChanges();
        }

        public IQueryable<int> HämtaAktiviteterGenomAlumn(AlumnDTO inloggadAlumn)
        {
            var db = new DatabaseContext();

            return db.AlumnAktivitet.Where(x => x.AlumnID == inloggadAlumn.AnvändarID)
                 .Select(x => x.AktivitetID);
        }

        public AktivitetDTO HämtaAktivitetIDGenomInformationsutskicksID(int utskicksID)
        {
            var db = new DatabaseContext();


            var list = db.InformationsutskickAktivitet.Where(x => x.InformationsutskickID.Equals(utskicksID)).Select(x => x.Aktivitet).SingleOrDefault();
            return list;
        }

        public IQueryable<AlumnAktivitetBokningDTO> HämtaAlumnGenomAktivitetsID(int aktivitetsID)
        {
            var db = new DatabaseContext();
            return db.AlumnAktivitet.Where(x => x.AktivitetID == aktivitetsID);
        }

        public AktivitetRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
