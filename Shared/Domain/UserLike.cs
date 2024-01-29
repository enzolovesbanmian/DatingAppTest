namespace DatingAppTest.Shared.Domain
{
	public class UserLike : BaseDomainModel
	{
		public int UserLikeId { get; set; }
		public int SourceUserId { get; set; }
		public virtual User? SourceUser { get; set; }
		public int LikedUserId { get; set; }
		public virtual User? LikedUser { get; set; }

	}
}