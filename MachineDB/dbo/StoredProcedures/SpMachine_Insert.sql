CREATE PROCEDURE [dbo].[SpMachine_Insert]
	@Name nvarchar(50)
AS
begin
	insert into dbo.[Machine] (Name)
	values (@Name);
end
