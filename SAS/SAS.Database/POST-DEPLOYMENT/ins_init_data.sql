/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [def].[ActiveStatus] ([ID], [Status])
VALUES
(0, 'Disabled'),
(1, 'Enabled')

INSERT INTO [usr].[UserType] ([ID], [Type])
VALUES
(0, 'JTI'),
(1, 'Contractor'),
(2, 'Visitor')

INSERT INTO [usr].[Company] ([Name], [ActiveStatusID])
VALUES
('JTI', 1)

--TODO: REMOVE--
-------------------------------------------------------------------
INSERT INTO [usr].[Department] ([Name], [ActiveStatusID])
VALUES('IT', 1)

INSERT INTO [usr].[User] ([FirstName], [MiddleName], [LastName], [SAPNumber], [TabNumber], [Username], [UserTypeID], [ActiveStatusID], [CompanyID], [DepartmentID], [Email])
VALUES
('Denis', 'Sergeevich', 'Makilov', '5216751', '54121', 'JTICORP\CSTMAKILOD', 1, 1, 1, 1, 'Makolov.Denis@gmail.com')

INSERT INTO [loc].[AccessPoint] ([Name], [ActiveStatusID])
VALUES
(N'Проходная', 1),
(N'Проходная-2', 1)

INSERT INTO [loc].[AccessPointManager] ([AccessPointID], [UserID], [ActiveStatusID])
VALUES
(1, 1, 1),
(2, 1, 1)


INSERT INTO [loc].[Group] ([Name], [GroupTypeID], [ActiveStatusID])
VALUES
('IT', 0, 1)

INSERT INTO [loc].[GroupToAccessPoint] ([GroupID], [AccessPointID], [ActiveStatusID])
VALUES
(1, 1, 1),
(1, 2, 1)

INSERT INTO [rqs].[Customer] ([FirstName], [MiddleName], [LastName], [CustomerTypeID], [AdditionalInformation], [ActiveStatusID], [CompanyID], [DepartmentID], [Username])
VALUES
('Denis', 'Sergeevich', 'Makilov', 1, 'AdditionaInfo', 1, 1, 1, 'JTICORP\CSTMAKILOD')

INSERT INTO [rqs].[Request] ([ActiveStatusID], [AdditionalInformation], [BusinessReason], [CreateDate], [CreatorID], [CustomerID], [EndAccessDate], [StartAccessDate], [RequestTypeID], [Name])
VALUES
(1, 'Additional information request', 'Business reason of the request', GETDATE(), 1, 1, GETDATE(), GETDATE(), 1, 'RQST1')
-------------------------------------------------------------------

INSERT INTO [loc].[GroupType] ([ID], [Type])
VALUES
(0, 'ABC'),
(1, 'FortNet'),
(2, 'Other')

INSERT INTO [rqs].[RequestType] ([ID], [Type])
VALUES
(0, 'JTI'),
(1, 'Contractor'),
(2, 'Visitor')

INSERT INTO [rqs].[CustomerType] ([ID], [Type])
VALUES
(0, 'JTI'),
(1, 'Contractor'),
(2, 'Visitor')

INSERT INTO [rqs].[RequestAccessPointStatus] (ID, [Status])
VALUES
(0, 'On Approval'),
(1, 'Approved'),
(2, 'Rejected')

INSERT INTO [rqs].[RequestGroupStatus] ([ID], [Status])
VALUES
(0, 'On Approval')

INSERT INTO rqs.RequestedGroup (RequestID, GroupID, GroupName, GroupStatusID, ActiveStatusID)
VALUES
(1, 1, N'IT', 0, 1)

INSERT INTO rqs.RequestedAccessPoint (RequestedGroupID, AccessPointID, AccessPointName, AccessPointStatusID, ActiveStatusID)
VALUES
(1, 1, N'Проходная', 0, 1)