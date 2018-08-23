using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public enum TypeOfShift
    {
        FrontEnd, BackEnd, CallBack
    }

    public class WorkShift
    {
        public int WorkShiftID { get; set; }
        public int WorkDayID { get; set; }
        public int WorkerID { get; set; }
        public TypeOfShift? TypeOfShift { get; set; }
        public string Time { get; set; }

        public virtual ICollection<WorkDay> WorkDays { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}