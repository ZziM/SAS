CREATE TABLE [loc].[AreaManager](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[AreaID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[DLM] [datetime2](7) NULL
)