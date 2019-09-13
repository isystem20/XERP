using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class CurrencyDetails {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CompanyBankAccountId { get; set; }
        public string CurrencyCode { get; set; }
        public ICollection<Currencies> Currencies { get; set; }
    }

}