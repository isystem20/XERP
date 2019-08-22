using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Core.API.Models
{
    public class TableOptions
    {
        public int PageNum { get; set; } = 1;
        public int RecordCount { get; set; }
        public string SortType { get; set; } = "DESC";
        public TableOptionsFilter Filter { get; set; }



    }
}
