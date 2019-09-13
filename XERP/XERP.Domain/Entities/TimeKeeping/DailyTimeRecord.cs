using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class DailyTimeRecord
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
    
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
    }
}
