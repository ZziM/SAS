CREATE TABLE [loc].[LocationManager](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[LocationID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[ActiveStatusID] [int] NOT NULL,
	[DLM] [datetime2](7) NULL DEFAULT(GETDATE())
)