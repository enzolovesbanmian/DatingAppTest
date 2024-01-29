using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppTest.Shared.Domain
{
	public class User : BaseDomainModel
	{
		public int UserId { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public int? Age { get; set; }
		public string? Gender { get; set; }
		public virtual ICollection<Photo>? Photos { get; set; }

		public virtual ICollection<UserLike>? LikedUsers { get; set; }

		public virtual ICollection<UserLike>? LikedByUsers { get; set; }
		public virtual ICollection<Message>? MessagesSent { get; set; }
		public virtual ICollection<Message>? MessagesReceived { get; set; }

	}
}
