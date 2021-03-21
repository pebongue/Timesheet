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
-- Create date: 2009 - 07 - 23
-- Description:	return a list of work category or active task for the user
-- =============================================
CREATE PROCEDURE [dbo].[GetWorkCategory] 
	-- Procedure parameter
	@ActiverUserID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT (rtrim(cast(tblTask.IssueID AS varchar(8))) + ' ' + tblIssue.Title) AS TaskName, tblIssue.Company
	FROM tblTask join tblTaskUser
	ON tblTask.TaskID = tblTaskUser.TaskID
	join tblIssue
	ON tblIssue.IssueID = tblTask.IssueID
	WHERE tblTaskUser.UserID = @ActiveUserID
	and TaskStatusID = 3
	
	UNION
	
	SELECT TaskName, Company
	FROM tblOtherTasks
	WHERE active = 1

END
GO
