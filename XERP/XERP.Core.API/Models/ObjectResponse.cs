using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Core.API.Models
{
    public class ObjectResponse
    {
        public bool success { get; set; }
        public int page_num { get; set; }
        public int page_total { get; set; }
        public object result { get; set; }
    }
}
