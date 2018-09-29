CREATE TABLE [usr].[UserType](
	[ID] [int]  NOT NULL,
	[Type] [nvarchar](38) NOT NULL,
	[DLM] [datetime2](7) NOT NULL DEFAULT(GETDATE())
	)