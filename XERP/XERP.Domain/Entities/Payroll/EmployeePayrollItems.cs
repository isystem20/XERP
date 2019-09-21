using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class EmployeePayrollItems {
        public string Id  {get; set; }
        public string EmployeeId  {get; set; }
        public string PayrollItemId  {get; set; }
        public string CurrencyId  {get; set; }
        public string CurrencyRate  {get; set; }
        public decimal Amount  {get; set; }
        public DateTime DateEffective  {get; set; }
        public string Remarks  {get; set; }
        public string ConstantValue  {get; set; }
        public string Status  {get; set; }
        public string CompanyId  {get; set; }
        //public string BankNo  {get; set; } Support multiple bank account, for future
    }

}
