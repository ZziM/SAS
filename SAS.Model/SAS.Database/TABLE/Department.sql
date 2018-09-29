CREATE TABLE [usr].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](128) NOT NULL,
	[ActiveStatusID] [int] NOT NULL,
	[DLM] [datetime2](7) NOT NULL
	)