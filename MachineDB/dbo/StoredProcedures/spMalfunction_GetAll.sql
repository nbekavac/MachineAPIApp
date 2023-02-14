CREATE PROCEDURE [dbo].[spMalfunction_GetAll]

AS
begin
	select *
	from dbo.Malfunction;
end
