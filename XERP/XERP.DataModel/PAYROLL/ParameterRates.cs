
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.PAYROLL
    {
    public class ParameterRates {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string DayTypeId { get; set; }
        [Required]
        public string HourTypeId { get; set; }
        public decimal Rate { get; set; }
    }
}