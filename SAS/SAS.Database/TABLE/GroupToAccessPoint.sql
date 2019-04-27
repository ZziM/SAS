CREATE TABLE [loc].[GroupToAccessPoint]
(
	[GroupID] INT NOT NULL,
	[AccessPointID] INT NOT NULL,
	[ActiveStatusID] [INT] NOT NULL,
	[DLM] DATETIME2 NOT NULL DEFAULT(GETDATE())
	CONSTRAINT PK_GroupAccessPoint PRIMARY KEY (GroupID, AccessPointID)
)
