CREATE VIEW rqs.vw_requestedgroups
AS
SELECT g.ID, g.[Name], g.GroupTypeID, rg.RequestID, rg.RequestedGroupStatusID, rg.ActiveStatusID, rg.DLM FROM loc.[Group] g
JOIN rqs.RequestedGroup rg ON g.ID = rg.GroupID