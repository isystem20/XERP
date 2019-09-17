using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Common
{
	public class Regions {
		public string Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public decimal MWERate { get; set; }
        public string Description { get; set; }
		public DateTime EffectiveDate { get; set; }
		public bool Active { get; set; } = true;
	}
}