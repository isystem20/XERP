using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class PayrollItemTypes {
        public string Id { get; set; }
        public string Code { get; set;}
        public string Name { get; set; }
        public bool Active { get; set; }
    }

}

//Default values are
// Earning
// Deduction
// Allowance
// Loans