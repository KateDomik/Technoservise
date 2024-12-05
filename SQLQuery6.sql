
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 

	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN

	SET NOCOUNT ON;


	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
