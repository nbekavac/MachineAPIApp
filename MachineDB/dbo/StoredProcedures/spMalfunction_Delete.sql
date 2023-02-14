CREATE PROCEDURE [dbo].[spMalfunction_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Malfunction]
	where Id=@Id;
end
