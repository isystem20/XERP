using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class Loans {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string PayrollItemId { get; set; }
        public string PayrollScheduleId { get; set; }
        public DateTime Applicationdate { get; set; }
        public DateTime GrantedDate { get; set; }
        public int EffectiveMonth { get; set; }
        public int EffectiveYear { get; set; }
        public string EffectivePayrollScheduleId { get; set; }
        public string RefNo { get; set; }
        public int NoOfPayments { get; set; }
        public decimal PreviousPayments { get; set; }
        public decimal Principal { get; set; }
        public float InterestRate { get; set; }
        public float PenalyRate { get; set; }
        //public string InterestTypeId int
        public decimal Amortization { get; set; }
        public bool IsHold { get; set; } = false;
        public DateTime DateClosed { get; set; }
        public string CompanyId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedById { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModificationDate { get; set; }
        public int VersionNo { get; set; }
        public string Description { get; set; }
        //public string LoanFilingId int
        public decimal OtherPayments { get; set; }
        public bool IsOnetimeDeduction { get; set; } = false;
        public decimal PenaltyAmount { get; set; }
        public string Number { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime MonthlyPrincipalAmount { get; set; }
        public DateTime MonthlyInterestAmount { get; set; }
        //public string MonthYearPeriodEffective int
        public decimal LoanAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
    }
}