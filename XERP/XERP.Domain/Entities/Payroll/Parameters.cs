using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class Parameters {
        public string ID { get; set; }
        public string CompanyId { get; set; }
        public string Name  { get; set; }
        public float DaysInYear { get; set; }
        public float HoursInDay { get; set; }
        public string PaymentTypeId { get; set; }
        public string Comment { get; set; }
        public string ParameterRateId { get; set; }
        public bool IsStandard { get; set; }
        public bool Active { get; set; }
    }
}