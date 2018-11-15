namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = System.Guid.NewGuid();

			InsertTime = System.DateTime.Now;
			UpdateTime = System.DateTime.Now;
		}

		// **********
		public System.Guid Id { get; set; }
		// **********

		// **********
		public System.DateTime InsertTime { get; set; }
		// **********

		// **********
		public System.DateTime UpdateTime { get; set; }
		// **********
	}
}
