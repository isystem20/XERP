
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Payroll
{
    public class ParameterRates {
        
        public string Id { get; set; }
        
        public string DayTypeId { get; set; }
        
        public string HourTypeId { get; set; }
        public decimal Rate { get; set; }
    }
}