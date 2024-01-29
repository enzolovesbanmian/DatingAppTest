namespace DatingAppTest.Shared.Domain
{
	public class Photo : BaseDomainModel
	{
		public int PhotoId { get; set; }
		public string? Url { get; set; }
		public bool IsMain { get; set; }
		public int UserId { get; set; }
		public virtual User? User { get; set; }

	}
}