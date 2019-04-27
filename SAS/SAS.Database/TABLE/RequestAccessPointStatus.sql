CREATE TABLE [rqs].[RequestAccessPointStatus]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Status] NVARCHAR(64) NOT NULL,
	[DLM] [datetime2](7) NOT NULL DEFAULT(GETDATE())
)