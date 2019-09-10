using System;
using System.Collections.Generic;
using System.Text;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Enumerations;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class TimeLogFiling
    {
        public string Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public int TimeLogTypeId { get; set; }
        public DateTime Time { get; set; }
        public int FilingStatusId { get; set; }
        public string Remarks { get; set; }
        public int ApproverLevel { get; set; } // default is 1
        public bool Posted { get; set; }

        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }

        public Employee Employees { get; set; }
        public TimeLogType TimeLogTypes { get; set; }
        public FilingStatus FilingStatus { get; set; }
    }
}
