namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		public string Username { get; set; }
		// **********
	}
}
