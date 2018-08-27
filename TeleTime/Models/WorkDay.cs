using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public enum NameOfDay
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, InvoiceMonday, InvoiceTuesday, InvoiceWednesday, InvoiceThursday, InvoiceFriday
    }

    public class WorkDay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkDayID { get; set; }
        public NameOfDay NameOfDay { get; set; }
        public bool DayOfWork { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}