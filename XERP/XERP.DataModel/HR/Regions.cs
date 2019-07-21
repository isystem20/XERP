using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.DataModel.HR
{
	public class Regions {
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public float MWERate { get; set; }
		public DateTime EffectivityDate { get; set; }
		public bool Active { get; set; } = true;
	}
}