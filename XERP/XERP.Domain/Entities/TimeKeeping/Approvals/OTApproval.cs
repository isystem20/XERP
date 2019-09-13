﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.TimeKeeping.Approvals
{
    public class OTApproval
    {
        public string Id { get; set; }
        public string OTFilingId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string EmployeeApproverId { get; set; }
        public int PreviousFilingStatusId { get; set; } //In case it is modified. re-approved or disapproved / approved
        public int FilingStatusId { get; set; }
        public int ApproverLevel { get; set; }
        public string Remarks { get; set; }
    }
}
