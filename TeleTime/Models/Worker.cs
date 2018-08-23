using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public class Worker
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public virtual ICollection<WorkShift> WorkShifts { get; set; }
    }
}