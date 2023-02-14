CREATE PROCEDURE [dbo].[spMalfunction_Get]
	@Id int
AS
begin
	select *
	from dbo.[Malfunction]
	where Id=@Id;
end

