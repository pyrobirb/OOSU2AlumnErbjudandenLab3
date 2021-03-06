﻿using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using DataLayer.Contexts;
using DataLayer.Repositories.UniqueRepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UniqueRepository
{
    public class ProgramRepository : Repository<ProgramDTO>, IProgramRepository
    {
        public ProgramRepository(DatabaseContext context) : base(context)
        {

        }

        public IQueryable<ProgramDTO> HämtaProgramFörAlumn(AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();
            
                var query =  db.AlumnProgram.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Include(x=> x.Program);

                return query.Where(x => x.AlumnID == aktuellAlumn.AnvändarID).Select(x => x.Program);
            
        }

        public void LäggTillUtbildningTillAlumn(int id, string text)
        {
            using (var db = new DatabaseContext())
            {
                IQueryable<ProgramDTO> query = db.Program.Where(x => x.Namn.Equals(text));
                IQueryable<int> befintligtProgramID = query.Select(x => x.ProgramID);

                if (!query.Any())
                {
                    ProgramDTO program = new ProgramDTO()
                    {
                        Namn = text
                    };
                    db.Program.Add(program);
                    db.SaveChanges();

                    db.Program.Attach(program);

                    AlumnProgramDTO ap = new AlumnProgramDTO()
                    {
                        AlumnID = id,
                        ProgramID = program.ProgramID
                    };
                    this.Context.AlumnProgram.Add(ap);
                    this.Context.SaveChanges();
                }
                else
                {
                    IQueryable<AlumnProgramDTO> Dubbelkoll = db.AlumnProgram.Where(x => x.AlumnID == id).Where(x => x.ProgramID == befintligtProgramID.FirstOrDefault());

                    if (!Dubbelkoll.Any())
                    {
                        AlumnProgramDTO ap = new AlumnProgramDTO()
                        {
                            AlumnID = id,
                            ProgramID = befintligtProgramID.FirstOrDefault()
                        };
                        this.Context.AlumnProgram.Add(ap);
                        this.Context.SaveChanges();
                    }

                }

            }
        }

        public void TaBortProgram(ProgramDTO programDTO)
        {
            var db = new DatabaseContext();

            var query = db.Program.Where(x => x.ProgramID == programDTO.ProgramID).Select(x=>x).FirstOrDefault();
            db.Program.Remove(query);
            db.SaveChanges();
        }

        public void TaBortProgramFrånAlumn(ProgramDTO selectedProgramToRemove, AlumnDTO aktuellAlumn)
        {
            var db = new DatabaseContext();

            var query = db.AlumnProgram.Where(x => x.AlumnID == aktuellAlumn.AnvändarID && x.ProgramID == selectedProgramToRemove.ProgramID).Select(x => x).FirstOrDefault();
            db.AlumnProgram.Remove(query);
            db.SaveChanges();
        }
    }
}
