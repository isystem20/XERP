using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class ChangeShiftFiling
    {
        public string Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public int OldShiftScheduleId { get; set; }
        public int ShiftScheduleId { get; set; }
        public int FilingStatusId { get; set; }
        public string Remarks { get; set; }
        public int ApproverLevel { get; set; }
        public bool Posted { get; set; }

        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
    }
}
