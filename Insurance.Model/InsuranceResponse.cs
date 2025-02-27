using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Model
{
	public class InsuranceResponse
	{
		public Customer Customer { get; set; }
		public Policy Policy { get; set; }
	}
}
