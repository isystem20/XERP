using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
    public class EmployeePreviousER {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; } //Start of Service
        public DateTime EndDate { get; set; } //End of Service
        public int YearEnd { get; set; } // Year End of Service
        public decimal Rate { get; set; }
        public string Remarks { get; set; }
        //Number represents the equivalent field on BIR 2316 Report
        public decimal _25GrossTaxableCompensationIncome { get; set; }
        public decimal _3713thMonthPayAndOtherBenefits { get; set; }
        public decimal _39ContributionsAndUnionDues { get; set; }
        public decimal _40SalariesAndCompensation { get; set; }
        public decimal _51Taxable13thMonthPayAndOtherBenefits { get; set; }
        public decimal _27PremiumPaid { get; set; }
        public decimal _31TotalTaxWithheld { get; set; }
        public decimal _38DeMinimisBenefits { get; set; }
        public string CreatedById { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public string LastModifiedById { get; set; }
        [Required]
        public DateTime LastModifiedAt { get; set; }
        public ICollection<Employees> Employee { get; set; }
        public ICollection<PreviousEmployers> PreviousEmployer { get; set; }

    }

}
