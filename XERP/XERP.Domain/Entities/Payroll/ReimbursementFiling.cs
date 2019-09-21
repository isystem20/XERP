using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.Payroll
{
    public class ReimbursementFiling
    {
        public string Id { get; set; }
        public DateTime? AppliedDate { get; set; }
        public string Description { get; set; }
        public int FilingStatusId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
