namespace DatingAppTest.Shared.Domain
{
	public class Message : BaseDomainModel
	{
		public int MessageId { get; set; }
		public int SenderId { get; set; }
		public string? SenderUsername { get; set; }	
		public virtual User? Sender { get; set; }
		public int RecipientId { get; set; }
		public string? RecipientUsername { get; set; }
		public virtual User? Recipient { get; set; }
		public string? Content { get; set; }
		public bool IsRead { get; set; }
	}
}