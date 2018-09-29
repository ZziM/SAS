CREATE TABLE [usr].[User]
(
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[TabNumber] NVARCHAR(16) NULL,
	[SAPNumber] NVArCHAR(16) NULL,
	[Username] [nvarchar](64) NULL,
	[FirstName] [nvarchar](128) NULL,
	[MiddleName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[Email] [nvarchar](128) NULL,
	[DepartmentID] [int] NULL,
	[CompanyID] [int] NULL,
	[UserTypeID] [int] NOT NULL,
	[ActiveStatusID] [int] NOT NULL,
	[DLM] [datetime2](7) NOT NULL DEFAULT(GETDATE()),
)
