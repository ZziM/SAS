CREATE TABLE [loc].[GroupType](
	[ID] [int] NOT NULL PRIMARY KEY,
	[Type] [nvarchar](64) NOT NULL,
	[DLM] [datetime2](7) NOT NULL DEFAULT(GETDATE())
	)