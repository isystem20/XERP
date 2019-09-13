using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class PayrollPeriods {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsRegular { get; set; }
        public bool IsFinalPay { get; set; }
        public bool IsAnnualization { get; set; }
        public bool Is13thMonthPay { get; set; }
        public bool IsRetirement { get; set; }
        public int AnnualizationOrdering { get; set; }
        public bool Active { get; set; }
        public bool IsStandard { get; set; }
        public int AnnualizationOrder { get; set; }
    }
}