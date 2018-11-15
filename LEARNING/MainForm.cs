using System.Linq;

namespace LEARNING
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User user = null;

				// **************************************************
				user = new Models.User();

				user.IsActive = true;
				user.Username = "Dariush";

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();
				// **************************************************

				// **************************************************
				var users =
					databaseContext.Users
					.Where(current => current.IsActive)
					.ToList()
					;

				if (users.Count != 0)
				{
					user = users[0];

					user.IsActive = false;
				}

				databaseContext.SaveChanges();
				// **************************************************

				// **************************************************
				users =
					databaseContext.Users
					.ToList()
					;

				if ((users != null) && (users.Count != 0))
				{
					user = users[0];

					users.Remove(user);
				}

				databaseContext.SaveChanges();
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
