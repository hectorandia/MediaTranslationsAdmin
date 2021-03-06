/*
   jueves, 15 de junio de 201715:10:53
   User: MediaAdmin
   Server: SERVER
   Database: MediaTranslations
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	CustomerID int NOT NULL IDENTITY (1, 1),
	Name nvarchar(50) NOT NULL,
	LastName nvarchar(50) NULL,
	Address nvarchar(50) NULL,
	City nvarchar(50) NULL,
	ZIP nvarchar(50) NULL,
	Country nvarchar(50) NULL,
	Email nvarchar(50) NULL,
	CompanyName nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	PK_Table_1 PRIMARY KEY CLUSTERED 
	(
	CustomerID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
