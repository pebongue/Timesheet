-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Placide Ebongue
-- Create date: 15 September 2009
-- Description:	Get the user default issues
-- =============================================
CREATE PROCEDURE TSGetUserIssues 
	-- Add the parameters for the stored procedure here
	@ActiveUserID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select 
			tblTask.IssueID as TASK_ISSUE_ID, tblIssue.Title as ISSUE_TITLE, tblIssue.Company
	From 
			tblTask JOIN tblTaskUser
			ON 
			tblTask.TaskID = tblTaskUser.TaskID
			JOIN tblIssue
			ON 
			tblIssue.IssueID = tblTask.IssueID
	Where 
			tblTaskUser.UserID = @ActiveUserID
			AND 
			TaskStatusID = 3
END
GO
