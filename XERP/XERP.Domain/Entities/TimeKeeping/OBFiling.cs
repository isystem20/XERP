using System;
using System.Collections.Generic;
using System.Text;
using XERP.Domain.Entities.CompanyResource;
using XERP.Domain.Entities.HumanResource;
using XERP.Domain.Enumerations;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class OBFiling
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; } //StartDate of OB
        public DateTime EndDate { get; set; }  //End of OB
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float ComputedHours { get; set; }
        public float ApprovedHours { get; set; }
        public int FilingStatusId { get; set; } //Filed, Approved, Disapproved
        public string CompanyClientId { get; set; }
        public string Description { get; set; }

        public bool Posted { get; set; } //Is Officially Posted
        public int ApproverLevel { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }

        public Employee Employees { get; set; }
        public CompanyClient CompanyClients { get; set; }
        public FilingStatus FilingStatus { get; set; }
    }
}
