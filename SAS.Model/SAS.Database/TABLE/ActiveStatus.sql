CREATE TABLE [def].[ActiveStatus]
(
	[ID] INT NOT NULL,
	[Status] NVARCHAR(64) NOT NULL,
	[DLM] [datetime2](7) NOT NULL DEFAULT(GETDATE()),
)