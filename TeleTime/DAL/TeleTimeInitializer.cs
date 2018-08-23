using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleTime.Models;

namespace TeleTime.DAL
{
    public class TeleTimeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeleTimeContext>
    {
        protected override void Seed(TeleTimeContext context)
        {
            var workers = new List<Worker>
            {
                new Worker{Name="David Welin", Role="A"},
                new Worker{Name="Rickard Fors", Role="B"},
                new Worker{Name="Kleif Persson", Role="C"},
                new Worker{Name="Karl Karlsson", Role="A"},
                new Worker{Name="Per Persson", Role="B"},
                new Worker{Name="Tuffs Katt", Role="C"},
                new Worker{Name="Pelle Svanslös", Role="A"},
                new Worker{Name="Björn Sten", Role="B"},
                new Worker{Name="Stig Helmer", Role="C"},
                new Worker{Name="Jennifer Lopez", Role="A"},
            };

            workers.ForEach(s => context.Workers.Add(s));
            context.SaveChanges();
            var workDays = new List<WorkDay>
            {
                new WorkDay{WorkDayID=1, NameOfDay=NameOfDay.Monday, DayOfWork=true},
                new WorkDay{WorkDayID=2, NameOfDay=NameOfDay.Tuesday, DayOfWork=true},
                new WorkDay{WorkDayID=3, NameOfDay=NameOfDay.Wednesday, DayOfWork=true},
                new WorkDay{WorkDayID=4, NameOfDay=NameOfDay.Thursday, DayOfWork=true},
                new WorkDay{WorkDayID=5, NameOfDay=NameOfDay.Friday, DayOfWork=true}
            };

            workDays.ForEach(s => context.WorkDays.Add(s));
            context.SaveChanges();
            var workShifts = new List<WorkShift>
            {
                new WorkShift{WorkDayID=1, WorkerID=1, TypeOfShift=TypeOfShift.FrontEnd, Time="0830-1000"},
                new WorkShift{WorkDayID=1, WorkerID=2, TypeOfShift=TypeOfShift.FrontEnd, Time="1000-1200"},
                new WorkShift{WorkDayID=1, WorkerID=3, TypeOfShift=TypeOfShift.FrontEnd, Time="1200-1400"},
                new WorkShift{WorkDayID=1, WorkerID=4, TypeOfShift=TypeOfShift.FrontEnd, Time="1400-1600"},
                new WorkShift{WorkDayID=2, WorkerID=5, TypeOfShift=TypeOfShift.FrontEnd, Time="0830-1000"},
                new WorkShift{WorkDayID=2, WorkerID=6, TypeOfShift=TypeOfShift.FrontEnd, Time="1000-1200"},
                new WorkShift{WorkDayID=2, WorkerID=7, TypeOfShift=TypeOfShift.FrontEnd, Time="1200-1400"},
                new WorkShift{WorkDayID=2, WorkerID=8, TypeOfShift=TypeOfShift.FrontEnd, Time="1400-1600"},
                new WorkShift{WorkDayID=3, WorkerID=9, TypeOfShift=TypeOfShift.FrontEnd, Time="0830-1000"},
                new WorkShift{WorkDayID=3, WorkerID=10, TypeOfShift=TypeOfShift.FrontEnd, Time="1000-1200"},
                new WorkShift{WorkDayID=3, WorkerID=1, TypeOfShift=TypeOfShift.FrontEnd, Time="1200-1400"},
                new WorkShift{WorkDayID=3, WorkerID=2, TypeOfShift=TypeOfShift.FrontEnd, Time="1400-1600"},
                new WorkShift{WorkDayID=4, WorkerID=3, TypeOfShift=TypeOfShift.FrontEnd, Time="0830-1000"},
                new WorkShift{WorkDayID=4, WorkerID=4, TypeOfShift=TypeOfShift.FrontEnd, Time="1000-1200"},
                new WorkShift{WorkDayID=4, WorkerID=5, TypeOfShift=TypeOfShift.FrontEnd, Time="1200-1400"},
                new WorkShift{WorkDayID=4, WorkerID=6, TypeOfShift=TypeOfShift.FrontEnd, Time="1400-1600"},
                new WorkShift{WorkDayID=5, WorkerID=7, TypeOfShift=TypeOfShift.FrontEnd, Time="0830-1000"},
                new WorkShift{WorkDayID=5, WorkerID=8, TypeOfShift=TypeOfShift.FrontEnd, Time="1000-1200"},
                new WorkShift{WorkDayID=5, WorkerID=9, TypeOfShift=TypeOfShift.FrontEnd, Time="1200-1400"},
                new WorkShift{WorkDayID=5, WorkerID=10, TypeOfShift=TypeOfShift.FrontEnd, Time="1400-1600"},
            };

            workShifts.ForEach(s => context.WorkShifts.Add(s));
            context.SaveChanges();
        }
    }
}