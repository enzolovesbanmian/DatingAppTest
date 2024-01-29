using DatingAppTest.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DatingAppTest.Server.Configuration.Entities
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasData(
			new User
			{
				UserId = 1,
				Username = "user1",
				Password = "password1",
				Age = 25,
				Gender = "Male",
				DateCreated = DateTime.Now,
				DateModified = DateTime.Now,
				CreatedBy = "System",
				ModifiedBy = "System"
			},
				new User
				{
					UserId = 2,
					Username = "user2",
					Password = "password2",
					Age = 28,
					Gender = "Female",
					DateCreated = DateTime.Now,
					DateModified = DateTime.Now,
					CreatedBy = "System",
					ModifiedBy = "System"
				}
				);
		}
	}
}
