CREATE TABLE [rqs].[RequestedAccessPoint]
(
	[ID] INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	[RequestedGroupID] INT NOT NULL,
	[AccessPointName] NVARCHAR(64),
	[AccessPointStatusID] INT NOT NULL,
	[ActiveStatusID] INT NOT NULL,
	DLM DATETIME2 DEFAULT(GETDATE())
)
