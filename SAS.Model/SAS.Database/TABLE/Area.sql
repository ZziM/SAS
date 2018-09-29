CREATE TABLE [loc].[Area](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](64) NOT NULL,
	[ActiveStatusID] [int] NOT NULL,
	[DLM] [datetime2](7) NULL
)