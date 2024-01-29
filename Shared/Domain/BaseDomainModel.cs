using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppTest.Shared.Domain
{
	public class BaseDomainModel
	{	
		public int Id { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;
		public DateTime? DateModified { get; set; }
		public string? CreatedBy { get; set; }
		public string? ModifiedBy { get; set; }
	}
}
