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

INSERT INTO [loc].[GroupType] ([ID], [Type])
VALUES
(0, 'ABC'),
(1, 'FortNet'),
(2, 'Other')

INSERT INTO [usr].[Company] ([Name], [ActiveStatusID])
VALUES
('JTI', 1)

--TODO: REMOVE--
-------------------------------------------------------------------
INSERT INTO [usr].[Department] ([Name], [ActiveStatusID])
VALUES('IT', 1)

INSERT INTO [usr].[User] ([FirstName], [MiddleName], [LastName], [SAPNumber], [TabNumber], [Username], [UserTypeID], [ActiveStatusID], [CompanyID], [DepartmentID])
VALUES
('Denis', 'Sergeevich', 'Makilov', '5216751', '54121', 'JTICORP\CSTMAKILOD', 1, 1, 1, 1)

INSERT INTO [loc].[Location] ([Name], [ActiveStatusID])
VALUES
('Проходная', 1),
('Проходная-2', 1)

INSERT INTO [loc].[LocationManager] ([LocationID], [UserID], [ActiveStatusID])
VALUES
(1, 1, 1),
(1, 1, 1)


INSERT INTO [loc].[Group] ([Name], [GroupTypeID], [ActiveStatusID])
VALUES
('IT', 0, 1)

INSERT INTO [loc].[GroupLocations] ([GroupID], [LocationID], [ActiveStatusID])
VALUES
(1, 1, 1),
(1, 2, 1)
-------------------------------------------------------------------

INSERT INTO [loc].[GroupType] ([ID], [Type])
VALUES
(0, 'ABC'),
(1, 'FortNet'),
(2, 'Other')