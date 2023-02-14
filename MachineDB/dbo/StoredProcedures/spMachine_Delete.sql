CREATE PROCEDURE [dbo].[spMachine_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Machine]
	where Id=@Id;
end