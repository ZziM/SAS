CREATE TABLE [loc].[GroupType](
	[ID] [int] IDENTITY(0,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](64) NOT NULL,
	[DLM] [datetime2](7) NULL
	)