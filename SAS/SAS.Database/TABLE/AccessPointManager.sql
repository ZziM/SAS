CREATE TABLE [loc].[AccessPointManager](
	[AccessPointID] [INT] NOT NULL,
	[UserID] [INT] NOT NULL,
	[ActiveStatusID] [INT] NOT NULL,
	[DLM] [DATETIME2](7) NULL DEFAULT(GETDATE())
	CONSTRAINT PK_LocationManager PRIMARY KEY ([AccessPointID], [UserID])
)