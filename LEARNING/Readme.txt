1)
	Model -> Repository

2)

	DatabaseContext -> UnitOfWork

	Model -> Repository

-------------------------------------------------------------------

SQL Server

			Table			Database

ADO.NET سنتی

			DataTable		DataSet

EF

			Model			DatabaseContext

Repository Pattern

			Repository		UnitOfWork

-------------------------------------------------------------------

3)

	DatabaseContext -> IUnitOfWork, UnitOfWork

	Model -> IRepository, Repository
