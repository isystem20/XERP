using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class PayrollItems {
       public string ID { get; set; }
       public string Code { get; set; }
       public string Name { get; set; }
       public string GroupCode { get; set; }
       public string HourTypeId { get; set; }
       public string DayTypeId { get; set; }
       public bool IsLoan { get; set; }
       public bool IncludeInSSS { get; set; }
       public bool IncludeInPHIC { get; set; }
       public bool IncludeInHDMF { get; set; }
       public bool IncludeInWTAX { get; set; }
       public bool IncludeIn13thMonthPay  { get; set; }
       public string SysCode { get; set; }
       public bool IsStandard { get; set; } 
       public string PayrollItemTypeId { get; set; } //Earnings, Deduction, Allowance, Loans and etc.
       public string CompanyId { get; set; }
       public bool Active { get; set; }
       public string Description { get; set; }
    }
}
