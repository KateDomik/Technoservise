--Хранимая процедура по номеру мастера
CREATE PROCEDURE Get_Request_Master_ID
	 @Master_ID int 
AS
BEGIN
     SELECT        Request_ID, Request_Date, Request_Master_ID
     FROM            dbo.Request
     WHERE        (Request_Master_ID = @Master_ID)
END
GO


exec Get_Request_Master_ID 105
