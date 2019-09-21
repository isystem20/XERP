using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.Payroll
{
    public class Payroll
    {
        public string Id { get; set; }
        public DateTime? TimeSheetStartDate { get; set; }
        public DateTime? TimeSheetEndDate { get; set; }
        public DateTime? PayoutDate { get; set; }
        public int PayYear { get; set; }
        public int PayMonth { get; set; }
        public int PayrollPeriodId { get; set; }
        public bool IsLocked { get; set; }
    }
}
