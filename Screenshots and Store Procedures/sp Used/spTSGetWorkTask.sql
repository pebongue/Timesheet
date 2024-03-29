USE [IMPRedux]
GO
/****** Object:  StoredProcedure [dbo].[TSGetWorkCategory]    Script Date: 07/31/2009 12:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Placide Ebongue
-- Create date: 2009 - 07 - 23
-- Description:	return a list of work category or active task for the user
-- =============================================
ALTER PROCEDURE [dbo].[TSGetWorkCategory] 
	-- Procedure parameter
	@ActiveUserID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
			(rtrim(cast(tblTask.IssueID AS varchar(8))) + ' ' + tblIssue.Title) AS TaskName, tblIssue.Company
	FROM 
			tblTask INNER JOIN tblTaskUser
					ON 
						tblTask.TaskID = tblTaskUser.TaskID
					INNER JOIN tblIssue
					ON 
						tblIssue.IssueID = tblTask.IssueID
	WHERE 
			tblTaskUser.UserID = @ActiveUserID
			AND TaskStatusID = 3
	
UNION
	
	SELECT TaskName, Company
	FROM tblOtherTasks
	WHERE active = 1

END
