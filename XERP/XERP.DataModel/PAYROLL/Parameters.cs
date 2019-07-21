using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.PAYROLL
{
    public class Parameters {
        public Guid ID { get; set; }
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