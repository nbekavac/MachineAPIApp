CREATE PROCEDURE [dbo].[spMachine_Update]
	@Id int,
	@Name nvarchar(50)
AS
begin
	update dbo.[Machine] 
	set Name=@Name
	where Id=@Id;
end
	
