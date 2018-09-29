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