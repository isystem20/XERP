using System;
using System.Collections.Generic;
using System.Text;

namespace XERP.Domain.Entities.Payroll
{

    //This should be historical, all payroll related data from 201 should include in this table.
    public class PayrollEmployees
    {
        public string Id { get; set; }
        public int PayrollId { get; set; }
        public string EmployeeId { get; set; }
        public int PayYear { get; set; }
        public int PayMonth { get; set; }
        public int PayrollPeriodId { get; set; }
        public string PayrollCode { get; set; } //this is the combination of Year, Month and Period, that will be used in sorting.

        //All EmployeePayrollSchemeId/EmployeeStateId should'nt be modified once used in this table
        public string EmployeePayrollSchemeId { get; set; }
        public string EmployeeStateId { get; set; }

        public decimal MonthlyRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal MonthlyAllowance { get; set; }
        public decimal DailyAllowance { get; set; }
        public decimal HourlyAllowance { get; set; }

        public decimal GrossEarnings { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; }


    }
}
