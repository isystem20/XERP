using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class TimeSheet
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string SchiftScheduleId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? StartTime { get; set; } //First In
        public DateTime? EndTime { get; set; } // Last Out

        public float PerfectHours { get; set; }

        public float Tardy { get; set; }
        public float Undertime { get; set; }
        
        public int DayTypeId { get; set; }
        public int HourTypeId { get; set; }

        public float ApprovedOBHours { get; set; } // Approved OB Hours
        public float ApprovedOTHours { get; set; } //Approved OT Hours
        public float ApprovedLeaveHours { get; set; } // Approved Leave Hours
        public float ApprovedNDOT { get; set; } //Approved OT Hours

        public float CreditedHours { get; set; }
        public float CreditedND { get; set; }
        public float CreditedNDOT { get; set; }
        public float CreditedOBHours { get; set; } // Approved OB Hours
        public float CreditedOTHours { get; set; } //Approved OT Hours
        public float CreditedLeaveHours { get; set; } // Approved Leave Hours

        public bool IsAbsent { get; set; } //If Daily Time Record is not completed
        public bool IsLocked { get; set; }




    }
}
