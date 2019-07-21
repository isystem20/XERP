using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.PAYROLL
{
    public class PayrollPeriods {
        public Guid Id { get; set; }
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
    }
}