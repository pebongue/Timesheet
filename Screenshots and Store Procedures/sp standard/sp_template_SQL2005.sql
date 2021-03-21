SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON 
GO

IF EXISTS (SELECT '*' FROM sysobjects WHERE ID = OBJECT_ID(N'template_proc') 
           AND OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE template_proc
GO

/******************************************************************************************                                                                        
 Stored Procedure	: template_proc.sql  
 Author				: Developer's Full Name
 Create Date		: Procedure creation date
                                     
 Purpose			: Description of what this stored proc is supposed to accomplish.  
 Input Parameters	: Required
                   	  @required_parm = 'what are the valid values'

                   	  Optional
                   	  @optional_parm = 'what are the valid values'
 Output Parameters	:

 Usage				: EXECUTE template_proc	@required_parm = 'test', 
					   	@optional_parm = 'test'
  
 Called By			: Calling object name
 Referenced Tables	: List of tables referring inside the procedure
 Referenced Objects	: List of objects referring inside the procedure 
					  Examples are: views, stored procedures, functions etc.
                 
                                                        
 Revision History                                                                                                                     
 Name			Date		Description                                           
 --------------------------------------------------------------------------------------- 


********************************************************************************************/ 
CREATE PROCEDURE template_proc
(
	@required_parm 		VARCHAR(5),
	@optional_parm 		VARCHAR(10) = NULL
)
AS
BEGIN

	SET NOCOUNT ON --only once 

	-- declare variables
	DECLARE @myerror	INT ,
	        @mymsg      VARCHAR(500) ,
			@Var1		VARCHAR(20) ,
	        @var2		VARCHAR(20) ,
	        @var3		VARCHAR(10)

	-- declare table variables
	DECLARE @sample TABLE (	EmpNo	INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
			 				EmpName	VARCHAR (50) NOT NULL)	
	

	--Validate input parameters here

	-- initialize variables
	SET @myerror = 0
	SET @mymsg = ''
	SET @Var1 = NULL
	SET @Var2 = NULL
	SET @Var3 = 'FALSE'


	-- perform business logic
	-- begin transaction when ready to modify data
	BEGIN TRANSACTION;

	BEGIN TRY
		-- Generate a constraint violation error.
		INSERT OR DELETE OR UPDATE statement
	END TRY;

	BEGIN CATCH
		SELECT 
			ERROR_NUMBER() AS ErrorNumber
			,ERROR_SEVERITY() AS ErrorSeverity
			,ERROR_STATE() AS ErrorState
			,ERROR_PROCEDURE() AS ErrorProcedure
			,ERROR_LINE() AS ErrorLine
			,ERROR_MESSAGE() AS ErrorMessage;

		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
	END CATCH;

	IF @@TRANCOUNT > 0
		COMMIT TRANSACTION;
	

	--Cleanup the temporary tables
    

END

GO 