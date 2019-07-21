using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.PAYROLL
{
    public class Currencies {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }

}