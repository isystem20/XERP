using System;
using System.Collections.Generic;
using System.Text;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Domain.Entities.TimeKeeping
{
    public class EmployeeApprovers
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeApproverId1 { get; set; }
        public string EmployeeApproverId2 { get; set; }
        public string EmployeeApproverId3 { get; set; }
        public string EmployeeApproverId4 { get; set; }

        public int Level { get; set; }
        public bool OBFiling { get; set; }
        public bool OTFiling { get; set; }
        public bool ChangeShiftFiling { get; set; }
        public bool LeaveFiling { get; set; }
        public bool TimeLogFiling { get; set; }
        public Employee Employees { get; set; }
    }
}
