using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.PAYROLL
{
    public class CurrencyDetails {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CompanyBankAccountId { get; set; }
        public string CurrencyCode { get; set; }
        public ICollection<Currencies> Currencies { get; set; }
    }

}