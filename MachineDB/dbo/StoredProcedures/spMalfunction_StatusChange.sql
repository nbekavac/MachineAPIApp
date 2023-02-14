CREATE PROCEDURE [dbo].[spMalfunction_StatusChange]
	@Id int,
	@Status nvarchar(50)
	
AS
begin
	update dbo.[Malfunction]
	set  Status=@Status
	where Id=@Id;
end
