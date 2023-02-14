CREATE PROCEDURE [dbo].[spMachine_Get]
	@Id int
AS
begin
	select *
	from dbo.[Machine]
	where Id=@Id;
end
