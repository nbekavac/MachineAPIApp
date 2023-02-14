CREATE PROCEDURE [dbo].[spMachine_GetAll]
	
AS
begin
	select *
	from dbo.[Machine];
end
