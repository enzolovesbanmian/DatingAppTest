using DatingAppTest.Server.Configuration.Entities;
using DatingAppTest.Server.Models;
using DatingAppTest.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace DatingAppTest.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Photo> Photos { get; set; }
		public DbSet<UserLike> UserLikes { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new UserSeedConfiguration());

			builder.Entity<UserLike>()
			.HasKey(k => new { k.SourceUserId, k.LikedUserId });

			builder.Entity<UserLike>()
				.HasOne(s => s.SourceUser)
				.WithMany(l => l.LikedUsers)
				.HasForeignKey(s => s.SourceUserId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<UserLike>()
				.HasOne(s => s.LikedUser)
				.WithMany(l => l.LikedByUsers)
				.HasForeignKey(s => s.LikedUserId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<Message>()
				.HasOne(m => m.Recipient)
				.WithMany(m => m.MessagesReceived)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Message>()
				.HasOne(m => m.Sender)
				.WithMany(m => m.MessagesSent)
				.OnDelete(DeleteBehavior.Restrict);
			base.OnModelCreating(builder);
		}
	}
}